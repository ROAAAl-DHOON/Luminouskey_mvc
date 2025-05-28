using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace Task2.Models
{
    public class Information
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public string Email { get; set; }
        public string phone_number { get; set; }
        public string Education { get; set; }
        public string Skills { get; set; }
        public string Projects { get; set; }
        public string Languages { get; set; }
    
    public Information GetInfo(int? id )
    {
        Information info1= new Information();
        switch( id ) {
            case 1:
                {
                    info1.Name = "Roaa";
                    info1.Summary = "1111";
                    info1.Email = "roaa@gmail.com";
                    info1.phone_number = "0771111111";
                    info1.Education = "Computer Engineering";
                    info1.Skills = "1111";
                    info1.Projects = "1111";
                    info1.Languages = "English ";
                    break;
                }
            case 2:
                {
                    info1.Name = "Shaima";
                    info1.Summary = "2222";
                    info1.Email = "shaima@gmail.com";
                    info1.phone_number = "0771111111";
                    info1.Education = "Software Engineering";
                    info1.Skills = "2222";
                    info1.Projects = "2222";
                    info1.Languages = "English ";
                    break;
                }
            case 3:
                {
                    info1.Name = "Hamzeh";
                    info1.Summary = "3333";
                    info1.Email = "hamzeh@gmail.com";
                    info1.phone_number = "0771111111";
                    info1.Education = "CS";
                    info1.Skills = "3333";
                    info1.Projects = "3333";
                    info1.Languages = "English ";
                    break;
                }

              
        }
        return info1;
    }
}
}
