namespace CurrencyProva {
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ContextModel1 : DbContext {
        // Your context has been configured to use a 'ContextModel1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CurrencyProva.ContextModel1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ContextModel1' 
        // connection string in the application configuration file.
        public ContextModel1()
            : base("name=ContextModel1") {
            }

        public virtual DbSet<User> Users {
            get;
            set;
            }

        public virtual DbSet<Currency> Currencies {
            get;
            set;
            }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    }