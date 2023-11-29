using System;
using System.Text.Json;
using AutoMapper;

namespace PostDTOConsole
{
     class Program
    {
        static void Main(string[] args)
        {
            // Your JSON data as a string
            string jsonData = "{\"Id\": 1, \"Title\": \"Sample Title\", \"Content\": \"Sample Content\"}";

            // Deserialize JSON to your original class
            var originalPost = JsonSerializer.Deserialize<OriginalPost>(jsonData);

            // Configure AutoMapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OriginalPost, PostDTO>();
                // Add additional mappings if needed
            });

            // Create the mapper
            var mapper = new Mapper(config);

            // Map the original post to PostDTO
            var postDto = mapper.Map<PostDTO>(originalPost);

            // Print the result
            Console.WriteLine($"Mapped PostDTO: Id = {postDto.Id}, Title = {postDto.Title}, Content = {postDto.Content}");
            Console.Read();
        }
    }
}
