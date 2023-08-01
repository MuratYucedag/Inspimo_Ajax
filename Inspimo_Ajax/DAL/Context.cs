using Microsoft.EntityFrameworkCore;

namespace Inspimo_Ajax.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R7AR1ND;initial Catalog=AjaxDb;integrated Security=true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}

//4-6-7 --> E-Ticaret --> Ece-Serkan-İpek
//9-1-12 --> Sağlık Yönetimi --> Ali Kaan-Mert-Hakan
//3-8 --> Bilet Sistemi --> Ecenur-İsmail-Yusuf
//2-10 --> Onedio --> Saadet-Enes
//5-13-11 --> Sözlük/Forum --> Hüseyin-Erhan-Zehra
//N Tier Arc. Azure Devops --> (Angular)


//Ali Kaan 1 
//Ece 2 
//Enes 3 
//Erhan 4
//Hüseyin 5 
//İpek 6 
//İsmail 7 
//Mert 8 
//Saadet 9 
//Hakan 10
//Ecenur 11
//Zehra 12
//Urfa Kralı 13




//8-9-11-2-4-13-6-7-1-3-5-10-12