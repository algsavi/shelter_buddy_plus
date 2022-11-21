using GraphQL;
using GraphQL.Client.Abstractions;
using ShelterBuddy.CodePuzzle.AdmWebApp.GraphQL.ResponseTypes;
using ShelterBuddy.CodePuzzle.AdmWebApp.Models;

namespace ShelterBuddy.CodePuzzle.AdmWebApp.GraphQL.Consumers
{
    public class AnimalConsumer
    {
        private readonly IGraphQLClient _client;

        public AnimalConsumer(IGraphQLClient client)
        {
            _client = client;
        }

        public async Task<List<AnimalModel>> GetAll()
        {
            var query = new GraphQLRequest
            {
                Query = @"
                query {
                    animals {
                    name,
                    colour,
                    microchipNumber,
                    dateOfBirth,
                    specie
                    }
                }"
            };

            var response = await _client.SendQueryAsync<ResponseAnimalCollectionType>(query);
            return response.Data.Animals;
        }
    }
}
