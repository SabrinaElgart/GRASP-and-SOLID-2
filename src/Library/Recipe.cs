//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public string GetText() //se crea el método GetTex para obtener el texto. La responsabilidad de imprimirlo está en otra clase (ConsolePrinter)
        {
            StringBuilder stringBuilder = new StringBuilder($"Receta de {this.FinalProduct}");
            foreach(Step step in this.steps)
            {
                stringBuilder.Append($"\n{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            return stringBuilder.ToString();
        }

       /* public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
       */ 
    }
}
 
/*
Anteriomente la clase Recipe tenía la responsabilidad de imprimir la receta, ahora se la asigno a otra
clase, es decir divido las reponsabilidades. 
Por lo tanto, le quito la responsabilidad a la clase Recipe. 
Por lo dicho anteriormente, el principio utilizado para este caso el es de SRP. 

*/