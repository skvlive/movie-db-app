using System;
using System.Collections.Generic;
using System.Text;

namespace movie_db_app.Domain.Entities
{
    public class ProductionCompany
    {
        public int Id { get; set; }
    
        public string LogoPath { get; set; }
    
        public string Name { get; set; }
        
        public string OriginCountry { get; set; }
    }
}
