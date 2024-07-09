# Inventory Management

An inventory management system which allows users to add, remove, and view items in the inventory.

## Requirements

1. Class `Item`, which has name (readonly), quantity, and created date, which are private. 
2. Contructor to take parameters of name, quantity, and created date (optional, if not set, it will be current date).

3. Class `Store` with the following properties and methods:
  - A collection to store items, which is private. Initially, this will be an empty collection.
  - Methods to add/delete one item to the collection. Do not allow to add items with same name to the store
  - Method `GetCurrentVolume` to compute the total amount of items in the store
  - Method `FindItemByName` to find an item by name.
  - Method `SortByNameAsc`to get the sorted collection by name in ascending order.

## Functionalities

- Method `SortByDate` to get the sorted collection by date dynamically (asc or desc)
- Method `GroupByDate` to return 2 groups `New Arrival` and `Old` items. `New Arrival` items are those created within the last three months. For example, if the current month is October, then items created in August, September, and October are categorized as `New Arrival`. Items created before August are categorized as `Old`.

## Sample of Code for testing
```
// items example - You do not need to follow exactly the same
var waterBottle = new Item("Water Bottle", 10, new DateTime(2023, 1, 1));
var chocolateBar = new Item("Chocolate Bar", 15, new DateTime(2023, 2, 1));
var notebook = new Item("Notebook", 5, new DateTime(2023, 3, 1));
var pen = new Item("Pen", 20, new DateTime(2023, 4, 1));
var tissuePack = new Item("Tissue Pack", 30, new DateTime(2023, 5, 1));
var chipsBag = new Item("Chips Bag", 25, new DateTime(2023, 6, 1));
var sodaCan = new Item("Soda Can", 8, new DateTime(2023, 7, 1));
var soap = new Item("Soap", 12, new DateTime(2023, 8, 1));
var shampoo = new Item("Shampoo", 40, new DateTime(2023, 9, 1));
var toothbrush = new Item("Toothbrush", 50, new DateTime(2023, 10, 1));
var coffee = new Item("Coffee", 20);
var sandwich = new Item("Sandwich", 15);
var batteries = new Item("Batteries", 10);
var umbrella = new Item("Umbrella", 5);
var sunscreen = new Item("Sunscreen", 8);
```

## Result after running the program: 
![image](https://github.com/ReemOthm/sda-inventory_management/assets/86829326/b9f3746a-cbe6-42b9-a3bc-8af3f7697e7a)

![image](https://github.com/ReemOthm/sda-inventory_management/assets/86829326/255a7add-5802-446c-93b7-1de35db354b2)


![image](https://github.com/ReemOthm/sda-inventory_management/assets/86829326/0c2d0006-c1f9-4bb0-8b92-1d320b9cd4fd)
