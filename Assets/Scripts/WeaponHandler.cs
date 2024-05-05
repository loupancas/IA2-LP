using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public static class WeaponHandlerExtensions
{
    public static void SwitchToNextWeaponIfNoAmmo<T>(this IEnumerable<T> weapons, T currentWeapon, WeaponHandler<T> weaponHandler) where T : Weapon
    {
        if (weaponHandler.HasAmmo(currentWeapon))
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

    public WeaponHandler(List<T> weapons)
    {
        this.weapons = weapons;
    }

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

    // Método para equipar un arma
    public void EquipWeapon(T weapon)
    {
        // Implementar lógica de equipamiento de arma
    }

    // Método para verificar si un arma tiene municiones
    public bool HasAmmo(T weapon)
    {
        // Implementar lógica para verificar si el arma tiene municiones
        return weapon.HasAmmo(); // Call the HasAmmo method on the weapon object
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
