using System;

namespace Programa_04
{
    class Program
    {
        public static void Main(string[] args)
        {
             
            string datos = "";
            int edad = 0;
            int etapa = 0;
            double peso = 0.0;
            int opcion = 0;
            int niveldeactividad = 0;
                
            Console.WriteLine("Bienvenido/a a nuestra una empresa dedica a la nutrición canina.");
            Console.WriteLine("Por favor, digame:");
            do
            {
                Console.WriteLine("¿Cual es la etapa de su mascota?");
                Console.WriteLine("1 - Es un Cachorro");
                Console.WriteLine("2 - Es un Adulto");
                datos = Console.ReadLine();
                etapa = Convert.ToInt32(datos);

                    switch (etapa)
                    {
                        case 1:

                            Console.WriteLine("Por favor, digame:");

                            Console.WriteLine("¿Cual es el peso de su mascota?:");
                            datos = Console.ReadLine();
                            peso = Convert.ToDouble(datos);
        
                            Console.WriteLine("Y por ultimo, digame:");        
        
                            Console.WriteLine("¿Cuantos meses de edad tiene su mascota?");
                            Console.WriteLine("1 - 2 meses");
                            Console.WriteLine("2 - 3 meses");
                            Console.WriteLine("3 - 4 meses");
                            Console.WriteLine("4 - 5 meses");
                            Console.WriteLine("5 - 6 a 12 meses");
                            datos = Console.ReadLine();
                            edad = Convert.ToInt32(datos);
                
                            //Tamaño Miniatura
                            if(peso < 5 && peso >= 2) 
                            {
                    
                                switch (edad) 
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer 50 gramos de alimento.");
                                    break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer 60 gramos de alimento.");
                                    break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer 60 gramos de alimento.");
                                    break;
                                    case 4:
                                        Console.WriteLine("Su perro debe comer 60 gramos de alimento.");
                                    break;
                                    case 5:
                                        Console.WriteLine("Su perro debe comer 55 gramos de alimento.");
                                    break;
                                }
                            }

                            //Tamaño Pequeño
                            if(peso < 10 && peso >= 5) 
                            {
                    
                                switch (edad) 
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer 95 gramos de alimento.");
                                    break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer 110 gramos de alimento.");
                                    break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer 115 gramos de alimento.");
                                    break;
                                    case 4:
                                        Console.WriteLine("Su perro debe comer 115 gramos de alimento.");
                                    break;
                                    case 5:
                                        Console.WriteLine("Su perro debe comer 110 gramos de alimento.");
                                    break;
                                }

                            }
                            //Tamaño Pequeño
                            if(peso < 17 && peso >= 10) 
                            {
                    
                                switch (edad) 
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer 155 gramos de alimento.");
                                    break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer 185 gramos de alimento.");
                                    break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer 195 gramos de alimento.");
                                    break;
                                    case 4:
                                        Console.WriteLine("Su perro debe comer 190 gramos de alimento.");
                                    break;
                                    case 5:
                                        Console.WriteLine("Su perro debe comer 185 gramos de alimento.");
                                    break;
                                }

                            }

                            //Tamaño Mediano
                            if(peso < 25 && peso >= 17) 
                            {
                    
                                switch (edad) 
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer 215 gramos de alimento.");
                                    break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer 265 gramos de alimento.");
                                    break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer 285 gramos de alimento.");
                                    break;
                                    case 4:
                                        Console.WriteLine("Su perro debe comer 285 gramos de alimento.");
                                    break;
                                    case 5:
                                        Console.WriteLine("Su perro debe comer 280 gramos de alimento.");
                                    break;
                                }

                            }

                            //Tamaño Pequeño
                            if(peso < 32 && peso >= 27) 
                            {
                    
                                switch (edad) 
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer 270 gramos de alimento.");
                                    break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer 350 gramos de alimento.");
                                    break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer 375 gramos de alimento.");
                                    break;
                                    case 4:
                                        Console.WriteLine("Su perro debe comer 375 gramos de alimento.");
                                    break;
                                    case 5:
                                        Console.WriteLine("Su perro debe comer 370 gramos de alimento.");
                                    break;
                                }

                            }

                            //Tamaño Grande
                            if(peso < 40 && peso >= 32) 
                            {
                    
                                switch (edad) 
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer 300 gramos de alimento.");
                                    break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer 400 gramos de alimento.");
                                    break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer 440 gramos de alimento.");
                                    break;
                                    case 4:
                                        Console.WriteLine("Su perro debe comer 450 gramos de alimento.");
                                    break;
                                    case 5:
                                        Console.WriteLine("Su perro debe comer 450 gramos de alimento.");
                                    break;
                                }

                            }

                            //Tamaño Grande
                            if(peso < 50 && peso >= 40) 
                            {
                    
                                switch (edad) 
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer 355 gramos de alimento.");
                                    break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer 475 gramos de alimento.");
                                    break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer 525 gramos de alimento.");
                                    break;
                                    case 4:
                                        Console.WriteLine("Su perro debe comer 530 gramos de alimento.");
                                    break;
                                    case 5:
                                        Console.WriteLine("Su perro debe comer 530 gramos de alimento.");
                                    break;
                                }

                            }

                            //Tamaño Grande
                            if(peso < 60 && peso >= 50) 
                            {
                    
                                switch (edad) 
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer 405 gramos de alimento.");
                                    break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer 545 gramos de alimento.");
                                    break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer 610 gramos de alimento.");
                                    break;
                                    case 4:
                                        Console.WriteLine("Su perro debe comer 625 gramos de alimento.");
                                    break;
                                    case 5:
                                        Console.WriteLine("Su perro deberia comer como un adulto.");
                                    break;
                                }

                            }

                            //Tamaño Grande
                            if(peso < 70 && peso >= 60) 
                            {
                    
                                switch (edad) 
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer 450 gramos de alimento.");
                                    break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer 605 gramos de alimento.");
                                    break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer 685 gramos de alimento.");
                                    break;
                                    case 4:
                                        Console.WriteLine("Su perro deberia comer como un adulto.");
                                    break;
                                    case 5:
                                        Console.WriteLine("Su perro deberia comer como un adulto.");
                                    break;
                                }

                            }

                            //Tamaño Grande
                            if(peso < 90 && peso >= 70) 
                            {
                    
                                switch (edad) 
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer 485 gramos de alimento.");
                                    break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer 670 gramos de alimento.");
                                    break;
                                    case 3:
                                        Console.WriteLine("Su perro deberia comer como un adulto.");
                                    break;
                                    case 4:
                                        Console.WriteLine("Su perro deberia comer como un adulto.");
                                    break;
                                    case 5:
                                        Console.WriteLine("Su perro deberia comer como un adulto.");
                                    break;
                                }

                            }

                            //Tamaño Grande
                            if(peso >= 90) 
                            {
                    
                                switch (edad) 
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer 580 gramos de alimento.");
                                    break;
                                    case 2:
                                        Console.WriteLine("Su perro deberia comer como un adulto.");
                                    break;
                                    case 3:
                                        Console.WriteLine("Su perro deberia comer como un adulto.");
                                    break;
                                    case 4:
                                        Console.WriteLine("Su perro deberia comer como un adulto.");
                                    break;
                                    case 5:
                                        Console.WriteLine("Su perro deberia comer como un adulto.");
                                    break;
                                }

                            }

                            break;

                        case 2:
                           
                            Console.WriteLine("Por favor, digame:");

                            Console.WriteLine("¿Cual es el peso de su mascota?:");
                            datos = Console.ReadLine();
                            peso = Convert.ToDouble(datos);
        
                            Console.WriteLine("Y por ultimo, digame:");        
        
                            Console.WriteLine("¿Como considera usted el nivel de actividad de su mascota?");
                            Console.WriteLine("1 - Alta");
                            Console.WriteLine("2 - Normal");
                            Console.WriteLine("3 - Baja");
                            datos = Console.ReadLine();
                            niveldeactividad = Convert.ToInt32(datos);
                
                            //Tamaño Miniatura
                            if(peso < 5 && peso >= 2) 
                            {
                    
                                switch (niveldeactividad) 
                                {
                                    case 1:
                                        Console.WriteLine("Su perro debe comer entre 60 - 115 gramos de alimento.");
                                    break;
                                    case 2:
                                        Console.WriteLine("Su perro debe comer entre 55 y 100 gramos de alimento.");
                                    break;
                                    case 3:
                                        Console.WriteLine("Su perro debe comer entre 45 - 85 gramos de alimento.");
                                    break;
                                }

                            }
                
                            //Tamaño Pequeño
                            if(peso < 10 && peso >= 5) 
                            {
                    
                                switch (niveldeactividad) 
                                {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 115 - 190 gramos de alimento.");
                                break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 100 - 170 gramos de alimento.");
                                break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 85 - 145 gramos de alimento.");
                                break;
                                }        
                            }

                            //Tamaño Mediano
                            if(peso < 15 && peso >= 10) 
                            {
                    
                                switch (niveldeactividad) 
                                {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 190 - 255 gramos de alimento.");
                                break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 170 - 225 gramos de alimento.");
                                break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 145 - 195 gramos de alimento.");
                                break;
                                }        
                            }
                
                            //Tamaño Grande
                            if(peso < 25 && peso >= 15) 
                            {
                    
                                switch (niveldeactividad) 
                                {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 255 - 380 gramos de alimento.");
                                break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 225 - 330 gramos de alimento.");
                                break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 195 - 285 gramos de alimento.");
                                break;
                                }        
                            }
                
                            if(peso < 40 && peso >= 25) 
                            {
                    
                                switch (niveldeactividad) 
                                {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 380 - 535 gramos de alimento.");
                                break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 330 - 475 gramos de alimento.");
                                break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 285 - 410 gramos de alimento.");
                                break;
                                }        
                            }
                
                            if(peso < 55 && peso >= 40) 
                            {
                    
                                switch (niveldeactividad) 
                                {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 535 - 680 gramos de alimento.");
                                break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 475 - 600 gramos de alimento.");
                                break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 410 - 520 gramos de alimento.");
                                break;
                                }        
                            }

                            if(peso < 70 && peso >= 55) 
                            {
                    
                                switch (niveldeactividad) 
                                {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 680 - 820 gramos de alimento.");
                                break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 600 - 720 gramos de alimento.");
                                break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 520 - 620 gramos de alimento.");
                                break;
                                }        
                            }

                            if(peso < 90 && peso >= 70) 
                            {
                    
                                switch (niveldeactividad) 
 
                                {
                                case 1:
                                    Console.WriteLine("Su perro debe comer entre 820 - 985 gramos de alimento.");
                                break;
                                case 2:
                                    Console.WriteLine("Su perro debe comer entre 720 - 870 gramos de alimento.");
                                break;
                                case 3:
                                    Console.WriteLine("Su perro debe comer entre 620 - 750 gramos de alimento.");
                                break;
                                }        
                            }
                        break;

                    }
                
                Console.WriteLine("Si desea continuar escriba 1\n de lo contrario escriba 4");
                datos = Console.ReadLine();
                opcion = Convert.ToInt32(datos);
                
                Console.Clear();

            }while(opcion != 4);
            
        }
    }
}