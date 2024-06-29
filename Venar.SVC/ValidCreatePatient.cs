using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venar.DTO;
using Venar.Entities;
using Xceed.Wpf.Toolkit;

namespace Venar.SVC
{
    public class ValidCreatePatient
    {
        Patient Patient = new Patient();


        public bool ValidatePatient(PatientDto obj)
        {
            
            var result = false;

            
            if (string.IsNullOrEmpty(obj.name))
            {
                throw new ArgumentException("El Nombre es obligatorio.");
            }

        
            if (string.IsNullOrEmpty(obj.lastName))
            {
                throw new ArgumentException("El Apellido es obligatorio.");
            }

          
            if (string.IsNullOrEmpty(obj.dni) || !obj.dni.All(char.IsDigit))
            {
                throw new ArgumentException("El DNI es obligatorio y debe contener solo números.");
            }

            
            if (obj.DateOfBirth == default)
            {
                throw new ArgumentException("La Fecha de Nacimiento es obligatoria.");
            }

           
            if (string.IsNullOrEmpty(obj.gender) || !(obj.gender == "Masculino" || obj.gender == "Femenino" ))
            {
                throw new ArgumentException("El Género es obligatorio");
            }

           
            if (string.IsNullOrEmpty(obj.location))
            {
                throw new ArgumentException("La Localización es obligatoria.");
            }

           
            if (string.IsNullOrEmpty(obj.MedicalCoverage))
            {
                throw new ArgumentException("La Cobertura Médica es obligatoria.");
            }

           
            return result=true;
        }
    }


}
    


