using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.Name = "Rector";
            rectorPosition.Salary = 1000;

            Position viceFinPosition = new Position();
            viceFinPosition.Name = "Vicerector Financiero";
            viceFinPosition.Salary = 750;

            Position viceAcadPosition = new Position();
            viceAcadPosition.Name = "Vicerector Academico";
            viceAcadPosition.Salary = 780;

            Position contadorPosition = new Position();
            contadorPosition.Name = "Contador";
            contadorPosition.Salary = 500;

            Position jefeFinPosition = new Position();
            jefeFinPosition.Name = "Jefe Financiero";
            jefeFinPosition.Salary = 610;
            
            Position secFin1Position = new Position();
            secFin1Position.Name = "Secretaria Financiera 1";
            secFin1Position.Salary = 350;
            
            Position secFin2Position = new Position();
            secFin2Position.Name = "Secretaria Financiera 2";
            secFin2Position.Salary = 310;
            
            Position jefeRegPosition = new Position();
            jefeRegPosition.Name = "Jefe de Registro";
            jefeRegPosition.Salary = 640;
            
            Position secReg1Position = new Position();
            secReg1Position.Name = "Secretaria de Registro 1";
            secReg1Position.Salary = 360;
            
            Position secReg2Position = new Position();
            secReg2Position.Name = "Secretaria de Registro 2";
            secReg2Position.Salary = 400;
            
            Position asisReg1Position = new Position();
            asisReg1Position.Name = "Asistente de Registro 1";
            asisReg1Position.Salary = 170;
            
            Position asisReg2Position = new Position();
            asisReg2Position.Name = "Asistente de Registro 2";
            asisReg2Position.Salary = 250;
            
            Position mensRegPosition = new Position();
            mensRegPosition.Name = "Mensajero de Registro";
            mensRegPosition.Salary = 90;

            
            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);

            universityTree.CreatePosition(universityTree.Root, viceFinPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, contadorPosition, viceFinPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin1Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secFin2Position, contadorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeFinPosition, viceFinPosition.Name);

            universityTree.CreatePosition(universityTree.Root, viceAcadPosition, rectorPosition.Name);
            universityTree.CreatePosition(universityTree.Root, jefeRegPosition, viceAcadPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secReg1Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, secReg2Position, jefeRegPosition.Name);
            universityTree.CreatePosition(universityTree.Root, asisReg1Position, secReg2Position.Name);
            universityTree.CreatePosition(universityTree.Root, mensRegPosition, asisReg1Position.Name);
            universityTree.CreatePosition(universityTree.Root, asisReg2Position, secReg2Position.Name);

            universityTree.PrintTree(universityTree.Root);
            float totalSalary = universityTree.AddSalaries(universityTree.Root);
            Console.WriteLine($"Total Salaries: {totalSalary}");
            Console.ReadLine();
        }
    }
}
