﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Venar.Entities;
using Venar.Data;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System.Data;
using Venar.DTO;




    namespace Venar.SVC
    {
        public class PatientSVC
    {

        DataServices dataServices = new DataServices();

        public void CreatePatient(PatientDto patientDto)
        {
            string patientQuery = @"
        INSERT INTO Patients (Name, LastName, Dni, DateOfBirth)
        VALUES (@Name, @LastName, @Dni, @DateOfBirth);
        SELECT SCOPE_IDENTITY() AS Id;
    ";

            Dictionary<string, object> patientParams = new Dictionary<string, object>
    {
        { "@Name", patientDto.name },
        { "@LastName", patientDto.lastName },
        { "@Dni", patientDto.dni },
        { "@MedicalCoverage", patientDto.MedicalCoverage },
        { "@Gender", patientDto.gender },
        { "@Location", patientDto.location },
        { "@DateOfBirth", patientDto.DateOfBirth }
    };

            var dev = dataServices.Create(patientQuery, patientParams);

        }

        //public int CreatePatient(Patient patient)
        //{

        //    Dictionary<string, string> Parts = new Dictionary<string, string>();

        //    string query = "INSERT INTO Patients (name, lastName, dni, DateOfBirth, gender, location, medicalCoverage) VALUES (@Name, @LastName, @Dni, @DateOfBirth, @Gender, @Location, @MedicalCoverage)";


        //    Parts.Add("@Name", patient.name);
        //    Parts.Add("@LastName", patient.lastName);
        //    Parts.Add("@Dni", patient.dni.ToString());
        //    Parts.Add("@DateOfBirth", patient.DateOfBirth.ToString());
        //    Parts.Add("@Gender", patient.gender.ToString());
        //    Parts.Add("@Location", patient.location);
        //    Parts.Add("@MedicalCoverage", patient.MedicalCoverage);


        //    var executeResult = dataService.Execute(query, Parts);

        //    return executeResult;
        //}


        public bool UpdatePatient(Patient patient)
            {
                bool result = false;
                Dictionary<string, string> parts = new Dictionary<string, string>();
                string query = "UPDATE patients SET Name = @Name, LastName = @LastName, MedicalCoverage = @MedicalCoverage, gender =@Gender,location =@Location WHERE dni = @Dni";
                parts.Add("@Name", patient.name);
                parts.Add("@LastName", patient.lastName);
                parts.Add("@MedicalCoverage", patient.MedicalCoverage);
                parts.Add("@Gender", patient.gender.ToString());
                parts.Add("@Location", patient.location);

                var dev = dataServices.Execute(query, parts);

                return result;

            }


            public Patient SearchPat(int dni)
            {
                Dictionary<string, string> pats = new Dictionary<string, string>();
                string query = "SELECT Name, LastName, MedicalCoverage FROM patients WHERE dni = @Dni";

                pats.Add("@Dni", dni.ToString());

                var dev = dataServices.Selection(query, pats).Rows[0];

                return new Patient()
                {                   
                    name = dev["@Name"].ToString(),
                    lastName = dev["@LastName"].ToString(),
                    location = dev["@Location"].ToString(),
                    gender = Convert.ToInt16(dev["@Gender"]).ToString(),
                    MedicalCoverage = dev["@MedicalCoverage"].ToString(),
                };
            }





        }
    }