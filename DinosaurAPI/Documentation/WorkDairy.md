# 17-8-2021

1. Todo next create a way to get multiple images for one dinosaur of each type

        - Image for landdinosaurs is done, added three characters which will be picked randomly.

1. Level of dinosaur is setted to level 1 always when created so i can add this when creating the implementation for creating the dinosaur.

1. The Type of dinosaur needs to be picked randomly. For now we only got a Landdinosaur so i will set this manually for now. Later on i will have to randomly pick this and adjust the stats and characters accordinly to this.

1. Next to do is create the implementation for creating a dinosaur, in this case Land Dinosaur. After this i can do the same routine for Sea and Air dinosaurs. Then i can pick a random dinosaur in a new behavior.

                - I need to set the level manually, stats from program, name from input, image from program, type of dino manually.
                - Added sound effect for dinosaur

1. Done creating Land Dinosaur. Now add database to it, create table for the dinosaur, create controller etc.

1. Added Implementation, Added Database, Added database to Implementation, Added controller.

public int DinoLevel { get; set; }
public string DinosaurName { get; set; }
public string TypeOfDino { get; set; }
public double Health { get; set; } - DONE
public double Stamina { get; set; } - DONE
public double Strenght { get; set; } - DONE
public double Defence { get; set; } - DONE
public double Food { get; set; } - DONE
public double Intelligence { get; set; } - DONE
public string ImageLink { get; set; } - DONE


# 16-8-2021

        public double Health { get; set; } - DONE
        public double Stamina { get; set; } - DONE
        public double Strenght { get; set; } - DONE
        public double Defence { get; set; } - DONE
        public double Food { get; set; } - DONE
        public double Intelligence { get; set; } - DONE

1. Create implementations to generate stats for the dinosaur

1. Create inputs for rest of the dino
    public string DinosaurName { get; set; }


1. Todo next create a way to get multiple images for one dinosaur of each type


        public int DinoLevel { get; set; }
        public string DinosaurName { get; set; }
        public string TypeOfDino { get; set; }
        public double Health { get; set; }
        public double Stamina { get; set; }
        public double Strenght { get; set; }
        public double Defence { get; set; }
        public double Food { get; set; }
        public double Intelligence { get; set; }
        public string ImageLink { get; set; }