// Define a class representing a Car
class Car {
  // Properties
  private make: string;
  private model: string;
  private year: number;

  // Constructor
  constructor(make: string, model: string, year: number) {
      this.make = make;
      this.model = model;
      this.year = year;
  }

  // Method to get car details
  getDetails(): string {
      return `This car is a ${this.year} ${this.make} ${this.model}.`;
  }
}

// Create an instance of the Car class
let myCar = new Car("Toyota", "Camry", 2022);

// Get and display car details
console.log(myCar.getDetails());
