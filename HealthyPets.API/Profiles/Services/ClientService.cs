using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Repositories;
using HealthyPets.API.Profiles.Domain.Services;
using HealthyPets.API.Profiles.Domain.Services.Communication;
using HealthyPets.API.Shared.Domain.Repositories;

namespace HealthyPets.API.Profiles.Services;

public class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ClientService(IUnitOfWork unitOfWork, IClientRepository clientRepository)
    {
        _unitOfWork = unitOfWork;
        _clientRepository = clientRepository;
    }

    public async Task<IEnumerable<Client>> ListAsync()
    {
        return await _clientRepository.ListAsync();
    }
    
    public async Task<ClientResponse> SaveAsync(Client client)
    {
        try
        {
            await _clientRepository.AddAsync(client);
            await _unitOfWork.CompleteAsync();
            return new ClientResponse(client);
        }
        catch (Exception e)
        {
            return new ClientResponse($"An error occurred while saving the client: {e.Message}");
        }
        
    }

    public async Task<ClientResponse> UpdateAsync(int id, Client client)
    {
        var existingClient = await _clientRepository.FindByIdAsync(id);
        if (existingClient == null)
            return new ClientResponse("Client not found.");
        existingClient.Name = client.Name;
        existingClient.Pet = client.Pet;
        try
        {
            _clientRepository.Update(existingClient);
            await _unitOfWork.CompleteAsync();

            return new ClientResponse(existingClient);
        }
        catch (Exception e)
        {
         return new ClientResponse($"An error occurred while the client: {e.Message}");
        }
    }

    public async Task<ClientResponse> DeleteAsync(int id)
    {
        var existingClient = await _clientRepository.FindByIdAsync(id);
        if (existingClient == null)
            return new ClientResponse("Client not found");
        try
        {
            _clientRepository.Remove(existingClient);
            await _unitOfWork.CompleteAsync();
            return new ClientResponse(existingClient);
        }
        catch (Exception e)
        {
            return new ClientResponse($"An error occurred while deleting the client: {e.Message}");

        }
    }
}