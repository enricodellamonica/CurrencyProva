using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyProva {
    public class Currency {

        [Key]
        public int Id {
            get;
            set;
            }

        public string Name {
            get;
            set;
            }

        public decimal Price {
            get;
            set;
            }

        public string Symbol {
            get;
            set;
            }

        public string Ts {
            get;
            set;
            }

        public string Type {
            get;
            set;
            }

        public DateTime UcTime {
            get;
            set;
            }

        public int Volume {
            get;
            set;
            }

        [ForeignKey("User")]
        public int UserId {
            get;
            set;
            }

        public virtual User User {
            get;
            set;
            }
        }

    }
