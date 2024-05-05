using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


    public class WeaponHandler<T> : MonoBehaviour where T : Weapon
    {
        private List<T> weapons = new List<T>();

        // Método para agregar un arma al manejador
        public void AddWeapon(T weapon)
        {
            weapons.Add(weapon);
        }

        // Método para encontrar un arma por su nombre
        public T FindWeaponByName(string name)
        {
            return weapons.FirstOrDefault(weapon => weapon.name == name);
        }
    }

    // Extensión personalizada de LINQ que no utiliza funciones de LINQ existentes
    public static class CustomLINQExtensions
    {
        public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> source, System.Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach (T item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }

