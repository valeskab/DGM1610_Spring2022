using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    enum Color {blue, red, yellow, green, orange, purple};
    enum CarMake {Oldsmobile, Chevrolet, Ford, Mazda, Toyota, Dodge}
    enum CarModel {Alero, Cruze, Tacoma, Mustang, Miata, Viper};
    enum HighFashion {Gucci, Prada, Louisvouitton, Tiffany, Balenciaga, Channel, Dior}
    enum GameCompanies {Nintendo, Microsoft, Sony, Ubisoft, EA, Activision, SquareEnix}
    
    // Start is called before the first frame update
    void Start()
    {
       /* Color paint;
        paint = Color.purple;

        print(paint);
        */

        CarMake make;

        CarModel model;

        make = CarMake.Dodge;
        model = CarModel.Viper;

        // print("Car Manufacture:" + make + "Model:" + model);

        Recall(CarMake.Mazda, CarModel.Miata);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Recall(CarMake make, CarModel model)
    {
        if(make == CarMake.Oldsmobile && model == CarModel.Alero)
        {
            print("THere is a recall on your vehicle due to a faulty ignition, please take your car to the nearest dealer for repairs");
        }
        else if(make == CarMake.Ford && model == CarModel.Mustang)
        {
            print("There is a recall on all Mustangs for being too cool to drive!");
        }
        else
        {
            print("There is no recall notice for your behicle make and model");
        }
    }
}
