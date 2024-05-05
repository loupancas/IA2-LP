using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class EjemplosClase : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
    ////select
    //int[] intArray = new int[] { 1, 2, 3, 5 };
    //Character[] characters;

    //void Example()
    //{
    //    /*Convierte una colección de ints
    //    en una colección de strings*/
    //    var strings = intArray.Select(
    //        element => element.ToString());

    //    //Multiplica por dos todos los elementos
    //    var mult2 = intArray.Select(
    //        element => element * 2);

    //    /*Convierte lista de personajes en una lista de nombres*/
    //    var names = characters.Select(
    //        element => element.name);

    //    /*Convierte una lista de personajes en una lista del hp de los mismos (int)*/
    //    var hps = characters.Select(x => x.HP);
    //}

    ////where filtro

    //int[] ints = new int[] { 1, 3, 41, 4, 66, 4, 5, 120, 58 };
    //Character[] characters;

    //void Example()
    //{
    //    //Lista de enteros mayores que 4
    //    var greaterThan4 = ints.Where(x => x > 4);

    //    //Lista de enteros iguales a 4
    //    var equalTo4 = ints.Where(x => x == 4);

    //    var freeVar = 40;
    //    var lowerThanFreeVar = ints.Where(
    //        x => x < freeVar
    //    );

    //    //lista de personajes con < 10 de vida
    //    var lowHealthChars = characters.Where(
    //        c => c.HP < 10
    //    );

    //    //lista de personajes que sean Healers
    //    var supportCharacters = characters.Where(x => x is Healer);
    //}

    //int[] ints = new int[] { 1, 3, 2, 7, 6, 4, 5 };
    //Character[] characters;

    //void Example()
    //{
    //    //Lista de enteros mayores que 4,
    //    //elevados al cuadrado
    //    var greaterThan4 = ints
    //        .Where(x => x > 4)
    //        .Select(x => x * x);
    //    //Lista de enteros multiplicados por 2
    //    //menores a 10
    //    var equalTo4 = ints
    //        .Select(x => x * 2)
    //        .Where(x => x < 10);

    //    //nombres de personajes con
    //    //HP menor al 10%
    //    var lowHealthChars = characters
    //        .Where(c => (c.HP / c.MaxHP) < 0.1f)
    //        .Select(t => t.Item1.Name);
    //}

    ////extension
    //public static bool AtLeast(this IEnumerable<T> col, int am)
    //{
    //    return col.Skip(am - 1).Any();

    //}


}
