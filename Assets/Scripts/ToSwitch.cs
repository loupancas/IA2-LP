using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public static class ToSwitch
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

public static class WeaponExtensions
{
    public static void SwitchToNextWeaponIfNoAmmo<T>(this IEnumerable<T> weapons, T currentWeapon, WeaponHandler<T> weaponHandler) where T : Weapon
    {
        if (currentWeapon.HasAmmo())
        {
            return;
        }

        int currentIndex = weaponHandler.IndexOf(currentWeapon);
        int nextIndex = (currentIndex + 1) % weaponHandler.Count();

        // Switch to next weapon
        T nextWeapon = weaponHandler.GetWeaponAtIndex(nextIndex);
        weaponHandler.EquipWeapon(nextWeapon);
    }
}

public class WeaponHandler<T> : MonoBehaviour where T : Weapon
{
    private List<T> weapons = new List<T>();

    // Método para agregar un arma al manejador
    public void AddWeapon(T weapon)
    {
        weapons.Add(weapon);
    }

    // Método para equipar un arma
    public void EquipWeapon(T weapon)
    {
        // Implementar lógica de equipamiento de arma
    }

    // Método para verificar si un arma tiene municiones
    public bool HasAmmo()
    {
        // Implementar lógica para verificar si el arma tiene municiones
        return true; // Ejemplo: siempre devuelve verdadero por simplicidad
    }

    // Método para obtener el índice de un arma en la lista
    public int IndexOf(T weapon)
    {
        return weapons.IndexOf(weapon);
    }

    // Método para obtener un arma por índice
    public T GetWeaponAtIndex(int index)
    {
        return weapons[index];
    }

    // Método para obtener la cantidad de armas en el manejador
    public int Count()
    {
        return weapons.Count;
    }
}

