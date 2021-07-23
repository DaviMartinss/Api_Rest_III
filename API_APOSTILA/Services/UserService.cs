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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnityOfWork _unityOfWork;

        public UserService(IUserRepository userRepository, IUnityOfWork unityOfWork)
        {
            _userRepository = userRepository;
            _unityOfWork = unityOfWork;
             
        }

         public async Task<IEnumerable<User>> ListAsync()
        {
            return await _userRepository.ListAsync();
        }

        public async Task<UserResponse> SaveAsync(User User)
        {
            try
            {
                await _userRepository.AddAsync(User);
                await _unityOfWork.CompleteAsync();

                return new UserResponse(User);
            }
            catch (Exception ex )
            {
                return new UserResponse($"Falha: ocorreu um erro ao salvar o usuário: {ex.Message}");
            }
        }

        public async Task<UserResponse> UpdateAsync(User user, int id)
        {
            var User_exists = await _userRepository.FindByIdAsync(id);

            if ( User_exists == null)
            {
                return new UserResponse(message: "Usuário não existe");
            }
           
            User_exists.Login = user.Login;
            User_exists.Password = user.Password;

            try
            {
                _userRepository.Update( User_exists);
                await _unityOfWork.CompleteAsync();

                return new UserResponse( User_exists);
            }
            catch (Exception ex)
            {
                return new UserResponse($"Falha: Ocorreu um erro ao atualizar o usuário: {ex.Message}");
            }
        }

        public async Task<UserResponse> DeleteAsync(int id)
        {
            var  User_exists = await _userRepository.FindByIdAsync(id);

            if ( User_exists == null)
            {
                return new UserResponse("Usuario não existe");
            }

            try
            {
                _userRepository.Remove( User_exists);
                await _unityOfWork.CompleteAsync();

                return new UserResponse( User_exists);
            }
            catch (Exception ex)
            {
                return new UserResponse($"Falha: Ocorreu um erro ao deletar o usuário: {ex.Message}");
            }

        }
        public async Task<UserResponse> FirstOrDefaultAsync(String login, String password)
        {
            var  User_exists = await _userRepository.FirstOrDefaultAsync(login, password);
             if (User_exists == null)
            {
                return new UserResponse("Usuário não existe");
            }
            return new UserResponse(User_exists);

        }
    }
}
