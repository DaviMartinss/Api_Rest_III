using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_APOSTILA.Domain.Models;
using API_APOSTILA.Domain.Services;
using API_APOSTILA.Domain.Repositories;
using API_APOSTILA.Domain.Services.Communication;
using API_APOSTILA.Domain;

namespace API_APOSTILA.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnityOfWork _unityOfWork;

        public ProductService(IProductRepository productRepository, IUnityOfWork unityOfWork)
        {
            _productRepository = productRepository;
            _unityOfWork = unityOfWork;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }

        public async Task<ProductResponse> SaveAsync(Product product)
        {
            try
            {
                await _productRepository.AddAsync(product);
                await _unityOfWork.CompleteAsync();

                return new ProductResponse(product);
            }
            catch (Exception ex)
            {
                return new ProductResponse($"Ocorreu um erro ao salvar o produto: {ex.Message}");
            }
        }

        public async Task<ProductResponse> UpdateAsync(int id, Product product)
        {
            var product_exists = await _productRepository.FindByIdAsync(id);

            if (product_exists == null)
            {
                return new ProductResponse(Message: "O produto não existe.");
            }

            product_exists.Name = product.Name;

            try
            {
                _productRepository.Update(product_exists);
                await _unityOfWork.CompleteAsync();

                return new ProductResponse(product);
            }
            catch (Exception ex)
            {
                return new ProductResponse($"Ocorreu um erro ao atualizar o produto: {ex.Message}");
            }
        }

        public async Task<ProductResponse> DeleteAsync(int id)
        {
            var product_exists = await _productRepository.FindByIdAsync(id);

            if (product_exists == null)
            {
                return new ProductResponse("O produto não existe");
            }

            try
            {
                _productRepository.Remove(product_exists);
                await _unityOfWork.CompleteAsync();

                return new ProductResponse(product_exists);
            }
            catch (Exception ex)
            {

                return new ProductResponse($"Ocorreu um erro ao deletar o produto: {ex.Message}");
            }
        }
    }
}
