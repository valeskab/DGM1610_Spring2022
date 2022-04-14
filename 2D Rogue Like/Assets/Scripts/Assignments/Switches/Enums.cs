using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    enum Color {blue, red, yellow, green, orange, purple};
    enum CarMake {Oldsmobile, Chevrolet, Ford, Mazda, Toyota, Dodge}
    enum CarModel {Alero, Cruze, Tacoma, Mustang, Miata, Viper};
    enum GameCompanies {Nintendo, Riot, Capcom, Ubisoft, EA, Activision, SquareEnix}
    enum PopularGames {Mario, LeagueOfLegends, Sonic, JustDance, Fifa, Overwatch, FinalFantasy}
    enum CoffeeShops { Starbucks, DutchBros, BeansAndBrews, Beanys, GrindersCoffee, TheInsomniac}
    enum CoffeeDrinks {Capuccino, Expresso, Latte, Macchiato, Americano, Frappe, Mocha}
    enum Months {January, Febuary, March, April, May, June, July, August, September, October, November, December}
    enum Seasons { Summer, Winter, Fall, Spring}
    enum Holidays {Christmas, Easter, Halloween, Thanksgiving, SpringBreak}
    // Start is called before the first frame update
    void Start()
    {
       /* Color paint;
        paint = Color.purple;

        print(paint);

        CarMake make;

        CarModel model;

        make = CarMake.Dodge;
        model = CarModel.Viper;

        // print("Car Manufacture:" + make + "Model:" + model);


        GameCompanies publisher;
        publisher = GameCompanies.Nintendo;
        
        print(publisher);


        GameCompanies company;

        PopularGames vidgames;

        */

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
            print("There is a recall on your vehicle due to a faulty ignition, please take your car to the nearest dealer for repairs");
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

    void Recall(GameCompanies company, PopularGames vidgames)
    {
        if(company == GameCompanies.SquareEnix && vidgames == PopularGames.FinalFantasy)
        {
            print("Final Fantasy is an amazing video game series");
        }
        else if(company == GameCompanies.Riot && vidgames == PopularGames.LeagueOfLegends)
        {
            print("Touch some grass bro");
        }
        else
        {
            print("Cool");
        }
    }

    void Recall(CoffeeShops shops, CoffeeDrinks drinks)
    {
        if(shops == CoffeeShops.Beanys && drinks == CoffeeDrinks.Frappe)
        {
            print("This drink will boost magic power by 15%!");
        }
        else if(shops == CoffeeShops.Starbucks && drinks == CoffeeDrinks.Latte)
        {
            print("This drink will cure poison!");
        }
        else
        {
            print("This drink increases HP by 20%");
        }

    }

    



    
    
}
