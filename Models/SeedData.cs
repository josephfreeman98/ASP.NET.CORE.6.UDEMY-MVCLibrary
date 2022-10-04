using Microsoft.EntityFrameworkCore;
using MVCLibrary.Data;

namespace MVCLibrary.Models {
    public class SeedData {


        public static void Initialize(IServiceProvider serviceProvider) {


            using (var context = new LibraryContext(serviceProvider.GetRequiredService<
                DbContextOptions<LibraryContext>>())) {
                if (context.Book.Any()) {
                    return;
                }
                context.Book.AddRange(
                    new Book { Title = "Tiny C# Project", CallNumber = "AXS 2022" },
                    new Book { Title = "Tiny Flutter Project", CallNumber = "ARQ 2024" }
                    );
                context.SaveChanges();

            }
        }

        public string Name { get; set; }
    }
}
