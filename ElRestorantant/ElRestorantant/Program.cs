﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ElRestorantant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            _____________                                                                          _________           ______ _____                    ____________                  ______      _____              
            ___  __ )__(_)______________   _________________  ______     ___________  _________    __  ____/______________  /____(_)_____________ _    __  ___/__(_)______ _______  ____  /_____ __  /______________
            __  __  |_  /_  _ \_  __ \_ | / /  _ \_  __ \  / / /  _ \    __  ___/  / / /_  ___/    _  /    _  __ \  __ \_  //_/_  /__  __ \_  __ `/    _____ \__  /__  __ `__ \  / / /_  /_  __ `/  __/  __ \_  ___/
            _  /_/ /_  / /  __/  / / /_ |/ //  __/  / / / /_/ //  __/    _(__  )/ /_/ /_  /        / /___  / /_/ / /_/ /  ,<  _  / _  / / /  /_/ /     ____/ /_  / _  / / / / / /_/ /_  / / /_/ // /_ / /_/ /  /    
            /_____/ /_/  \___//_/ /_/_____/ \___//_/ /_/\__,_/ \___/     /____/ \__,_/ /_/         \____/  \____/\____//_/|_| /_/  /_/ /_/_\__, /      /____/ /_/  /_/ /_/ /_/\__,_/ /_/  \__,_/ \__/ \____//_/                                                                                                                                           /____/                                                                    
            ");
            Console.WriteLine(@"
                                                                                                                                                                        
                                                                                          ██████████████████████████████████████████                                                        
                                                                                          ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██                                                        
                                                                                          ██▒▒▒▒▒▒░░                        ▒▒▒▒▒▒██                                                        
                                                                                          ██▒▒▒▒░░                          ░░▒▒▒▒██                                                        
                                                                                          ██▒▒▒▒                              ▒▒▒▒██                                                        
                                                                                          ██▒▒▒▒▒▒                          ░░▒▒▒▒██                                                        
                                                                                          ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██                                                        
                                                                                          ██████████████████████████████████▓▓██████                                                        
                                                                                                  ██                      ▒▒░░                                                              
                                                ▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒  ▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒              
                                              ▒▒▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▒▒            
                                              ██▒▒▒▒▓▓▓▓░░░░▒▒▒▒▒▒▓▓▓▓░░░░▒▒▒▒▓▓▓▓░░░░▒▒▒▒▒▒▓▓▓▓▓▓░░▒▒▒▒▒▒▓▓▓▓░░▒▒▒▒▓▓▒▒░░░░▒▒▒▒▒▒▓▓▓▓░░░░░░▒▒▒▒▒▒▓▓▓▓░░▒▒▒▒▒▒▒▒▓▓░░░░░░░░▒▒████            
                                              ▒▒▒▒▒▒▒▒  ░░░░░░▒▒▒▒▒▒▒▒  ░░░░▒▒▒▒      ░░░░▒▒▒▒    ░░▒▒▒▒▒▒▒▒    ░░▒▒▒▒▒▒  ░░░░▒▒▒▒▒▒▒▒▓▓▒▒  ░░░░▒▒▒▒▒▒  ░░░░░░▒▒▒▒▒▒▓▓    ░░░░██            
                                            ░░▒▒▒▒▒▒    ░░▒▒▒▒▒▒▒▒▒▒  ░░▒▒▒▒▒▒▒▒    ░░▒▒▒▒▒▒▒▒    ░░▒▒▒▒▓▓▒▒    ░░▒▒▒▒▒▒░░  ░░░░▒▒▒▒▒▒▓▓▓▓    ░░▒▒▒▒▒▒▒▒░░  ░░░░░░▒▒▒▒▒▒░░  ░░░░            
                                          ░░▒▒▒▒▒▒  ░░░░▒▒▒▒▒▒▒▒▒▒  ░░░░▒▒▒▒▒▒    ░░▒▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒    ░░░░▒▒▒▒▒▒▒▒░░  ░░░░▒▒▒▒▒▒▓▓░░    ░░▒▒▒▒▒▒▓▓░░░░  ░░▒▒▒▒▒▒▒▒░░    ░░░░        
                                        ░░▒▒▒▒▒▒  ░░░░▒▒▒▒▒▒▒▒    ░░░░▒▒▒▒▒▒    ░░░░▒▒▒▒▓▓▒▒    ░░▒▒▒▒▒▒▓▓    ░░░░▒▒▒▒▒▒▒▒░░    ░░▒▒▒▒▒▒▒▒▓▓▒▒    ▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░▒▒▒▒▒▒▒▒░░  ░░░░      
                                      ░░▒▒▒▒▓▓░░  ░░▒▒▒▒▒▒▒▒    ░░░░▒▒▒▒▒▒░░    ░░▒▒▒▒▒▒░░    ░░░░▒▒▒▒▒▒▓▓    ░░░░▒▒▒▒▒▒▒▒▒▒░░  ░░░░▒▒▒▒▒▒▒▒▓▓    ░░░░▒▒▒▒▒▒▒▒▒▒▒▒  ░░░░░░▒▒▒▒▓▓▒▒  ░░░░    
                                    ░░▒▒▒▒▒▒░░    ▒▒▒▒▒▒▒▒░░    ░░▒▒▒▒▒▒░░      ░░▒▒▒▒▒▒      ░░░░▒▒▒▒▒▒▒▒      ░░░░▒▒▒▒▒▒▒▒░░    ░░░░▒▒▒▒▒▒▓▓      ░░░░▒▒▒▒▒▒▒▒▒▒    ░░░░▒▒▒▒▒▒▓▓▒▒  ░░░░  
                                  ░░▓▓▓▓▓▓▓▓▒▒▒▒▒▒▓▓▓▓▓▓▓▓▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▒▒▓▓▒▒▒▒▓▓▓▓▓▓▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▒▒
                                    ▒▒▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▓▓▒▒▒▒▓▓▒▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▓▓▒▒▓▓██▒▒▒▒▒▒▒▒▒▒░░
                                              ██▓▓░░░░░░██░░  ░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░    ░░░░▒▒▒▒▒▒░░░░░░░░▓▓░░░░░░▓▓░░  ▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒░░░░██░░▓▓██            
                                              ██▓▓░░░░░░██░░░░    ▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓░░░░░░░░░░░░▒▒▒▒░░░░▒▒▒▒▓▓░░░░░░██░░░░░░▓▓░░      ░░    ░░  ▒▒▒▒▒▒██░░▓▓██            
                                              ██▓▓░░░░░░██░░░░▒▒  ▒▒▒▒▒▒▒▒▓▓░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▓▓▒▒░░░░░░░░░░░░▒▒▒▒░░  ░░▒▒▒▒░░░░░░██░░░░░░▓▓░░░░░░            ▒▒▒▒▒▒██░░▓▓██            
                                              ██▓▓░░░░░░██░░░░▒▒▒▒  ▒▒▒▒▒▒▓▓░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓░░░░░░░░    ▒▒▒▒▒▒░░    ▒▒░░░░░░██░░░░░░▓▓░░░░▒▒▒▒    ▒▒▒▒▒▒▒▒▒▒▒▒██░░▓▓██            
                                              ████░░░░░░██░░░░▒▒▒▒    ▒▒▒▒▒▒░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▓▓▒▒░░░░░░░░░░    ▒▒▒▒▒▒▒▒░░▒▒░░░░░░▓▓░░░░░░▓▓░░  ░░░░░░    ░░░░▒▒▒▒▒▒██░░▓▓██            
                                              ██▓▓░░░░░░██░░░░▒▒░░▒▒    ▒▒▓▓░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░    ▒▒▒▒▒▒▒▒▒▒░░░░░░██░░░░░░▓▓░░  ░░  ░░░░    ░░▒▒▒▒▒▒██░░▓▓▓▓            
                                              ██▓▓░░░░░░██░░░░░░░░▒▒▒▒    ▒▒░░  ░░░░░░▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒  ░░▒▒▒▒▒▒▒▒░░░░░░██░░░░░░▓▓░░    ░░░░░░      ▒▒▒▒▒▒██░░▓▓██            
                                              ██▓▓░░░░░░██░░░░░░░░▒▒▒▒▒▒    ░░    ░░░░▒▒░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░▒▒▒▒░░  ░░▒▒▒▒░░░░░░██░░░░░░▓▓░░░░    ░░░░░░░░░░▒▒▒▒▒▒██░░▓▓██            
                                              ████░░░░░░▓▓░░░░▒▒░░▒▒▒▒▒▒▒▒    ░░    ░░▒▒░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░▒▒░░  ▒▒▒▒░░░░░░██░░░░░░▓▓░░░░░░    ░░░░░░░░░░▓▓▒▒██░░▓▓██            
                                              ████░░░░░░██░░░░░░░░▒▒▒▒▒▒▒▒▒▒  ░░      ▒▒░░░░▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░▒▒▒▒░░  ▒▒░░░░░░██░░░░░░▓▓░░░░░░░░░░    ░░░░▒▒▒▒▒▒██░░▓▓██            
                                              ██▓▓░░░░░░██░░░░░░░░▒▒▒▒▒▒▒▒▒▒  ░░░░    ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░▒▒▒▒▒▒  ░░░░░░░░██░░░░░░▓▓░░░░░░░░░░    ░░░░▒▒▒▒▒▒██░░▓▓██            
                                              ██▓▓░░░░░░██░░░░░░░░▒▒▒▒▒▒▒▒▒▒    ░░░░    ░░▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░░░░▒▒▒▒▒▒▒▒    ░░  ██░░░░░░▓▓░░░░░░░░░░░░    ░░▒▒▒▒▒▒██░░▓▓██            
                                              ██▓▓░░░░░░██░░░░▒▒░░▒▒▒▒▒▒▒▒▒▒░░    ░░░░░░    ▒▒▒▒▒▒▒▒▒▒▒▒  ░░░░░░░░▒▒░░▒▒▒▒▒▒▒▒░░  ░░  ██  ░░░░▓▓░░░░░░░░░░░░░░░░░░▒▒▒▒▒▒██░░▓▓██            
                                              ██▓▓░░░░░░██░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░    ░░▒▒▒▒    ▒▒▒▒▒▒▒▒▓▓  ░░░░░░░░░░░░▒▒▒▒▒▒▒▒▒▒  ░░░░██░░░░░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██░░▓▓██            
                                              ████  ░░░░██░░░░▒▒▒▒▒▒░░▒▒▒▒▒▒░░░░░░  ░░▒▒▒▒      ▒▒▒▒▒▒▓▓  ░░░░░░░░▒▒░░░░▒▒▒▒▒▒▒▒  ░░░░▓▓░░░░░░▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓██░░▓▓██            
                                              ██▓▓░░░░░░██▒▒  ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒  ░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░░░░░▓▓▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓██░░▓▓██            
                                              ██▓▓  ░░░░██▒▒▒▒      ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒░░    ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░░░░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓██▓▓▓▓██░░▓▓██            
                                              ████░░░░░░██░░░░▒▒▒▒    ▒▒▒▒▒▒▒▒▒▒░░░░░░▒▒░░░░▒▒▒▒▒▒      ▒▒▒▒░░░░░░▒▒▒▒░░▒▒▒▒▒▒▒▒░░░░░░██░░░░░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓██░░▓▓██            
                                              ██▓▓░░░░░░▓▓░░░░▒▒▒▒░░    ░░▓▓▒▒▒▒░░░░░░▒▒░░░░▒▒▒▒▒▒▒▒  ░░▒▒▒▒░░░░░░▒▒▒▒░░▒▒▒▒▒▒▒▒░░░░░░██░░░░░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓██░░▓▓██            
                                              ██▓▓░░░░░░██░░░░▒▒▒▒▒▒░░░░  ░░▒▒▒▒░░░░░░▒▒▒▒░░▒▒▒▒▒▒▓▓▒▒░░▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░██░░░░░░▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓██░░▓▓██            
                                              ██▓▓░░░░░░██░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒  ░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▓▓░░░░░░▓▓▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓██░░▓▓██            
                                              ████  ░░░░██░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓░░▒▒▒▒░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░░░██░░░░░░▓▓▓▓▒▒░░░░▒▒▒▒▒▒▒▒▒▒▓▓▓▓▓▓▓▓░░▓▓██            
                                              ██▓▓░░  ░░██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░░▓▓▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▓▓▓▓▒▒██░░▓▓██            
                                              ████  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▒▒░░░░░░░░░░░░▒▒░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▓▓██░░▓▓██            
                                              ████  ░░░░  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓▓▓██░░▓▓██            
                                              ██▓▓    ░░░░  ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▓▓▓▓▓▓▓▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▓▓██░░▓▓██            
                                              ████▒▒▓▓▓▓▓▓▓▓░░▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▒▒▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓██                                                                                                                                          /____/                                                                    
            ");
            Console.WriteLine("Chef d'oeuvre créés par Emil Néron et Nathan Savard");
            Centre test = new Centre();
            Console.ReadKey();
            test.Simulation();
        }
    }
}