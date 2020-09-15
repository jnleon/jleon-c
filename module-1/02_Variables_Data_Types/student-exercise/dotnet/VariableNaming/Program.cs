using System;
using System.Threading.Tasks.Dataflow;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int numberOfRacoonsPlaying = 3;
            int numberOfRacoonsGoingtoEatDinner = 2;
            int numberOfRacoonsLeftWoods = numberOfRacoonsPlaying - numberOfRacoonsGoingtoEatDinner;
            Console.WriteLine("Racoons left in wooods: " + numberOfRacoonsLeftWoods);

            /*
        4. There are 5 flowers and 3 bees. How many less bees than flowers?
        */
            int numberOfFlowers = 5;
            int numberofBees = 3;
            int numberOfLessBeesthanFlowers = numberOfFlowers - numberofBees;
            Console.WriteLine("Number of Bess Less than Flowers: " + numberOfRacoonsLeftWoods);
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int numberPigeonEatingBreadcrumbs = 1;
            int numberofOtherPidgeonCameLater = 1;
            int numberOfPidgeonsEatingBreadcrumbsnow = numberPigeonEatingBreadcrumbs + numberofOtherPidgeonCameLater;
            Console.WriteLine("Number of Pidgeons Eating Breadcrumbs now: " + numberOfPidgeonsEatingBreadcrumbsnow);
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int numberOfOwlsSittingOnFence = 3;
            int numberofOwlsJoinedLater = 2;
            int numberOfOwlsSittingonnFenceTotal = numberOfOwlsSittingOnFence + numberofOwlsJoinedLater;
            Console.WriteLine("Number of Owls Sitting On Fence Now: " + numberOfOwlsSittingonnFenceTotal);
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int numberOfBeaversWorkingOnCrib = 2;
            int numberofBeaversGoingForASwim = 1;
            int numberOfBeaversStillWorkingOnCrib = numberOfBeaversWorkingOnCrib - numberofBeaversGoingForASwim;
            Console.WriteLine("Number of Beavers still working on their crib: " + numberOfBeaversStillWorkingOnCrib);
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int numberOfToucansSittingOnTreeLimb = 2;
            int numberofToucansThatJoined = 1;
            int numberOfToucansTotalAfter = numberOfToucansSittingOnTreeLimb + numberofToucansThatJoined;
            Console.WriteLine("Number of Toucans in All: " + numberOfToucansTotalAfter);
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int numberOfSquirrelsInTree = 4;
            int numberofNutsInTree = 2;
            int numberOfSquirrelsMoreThanNuts = numberOfSquirrelsInTree - numberofNutsInTree;
            Console.WriteLine("Number of Squirrels More THan Nuts: " + numberOfSquirrelsMoreThanNuts);


            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            double priceQuarter = 0.25;
            double priceDime = 0.10;
            double priceNickel = 0.05;


            int numberOfQuarters = 1;
            int numberOfDimes = 1;
            int numberOfNickels = 2;

            Console.WriteLine("She found: $" + ((priceQuarter * numberOfQuarters) + (priceDime * numberOfDimes) + (priceNickel * numberOfNickels)));

            /*
             11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
             class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
             Mrs. Flannery's class bakes 17 muffins. How many muffins does first
             grade bake in all?
             */

            int numberOfMuffinsMrsBriers = 18;
            int numberOfMuffinsMrsMacAdams = 20;
            int numberOfMuffinsMrsFlannery = 20;
            int numberOfMuffinsInTotal = numberOfMuffinsMrsBriers + numberOfMuffinsMrsMacAdams + numberOfMuffinsMrsFlannery;

            Console.WriteLine("First grade bakes " + numberOfMuffinsInTotal + " Muffins in total.");

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            double priceOfYoyo = 0.24;
            double priceOfWhistle = 0.14;

            double moneyspentInAllToys = priceOfYoyo + priceOfWhistle;
            Console.WriteLine("Mrs. Hilt spent $" + moneyspentInAllToys + " for the two toys.");

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */

            int numberOfLargeMarshmallows = 8;
            int numberOfMiniMarshmallows = 10;

            int numberOfMarhsmallowsAllTogether = numberOfLargeMarshmallows + numberOfMiniMarshmallows;
            Console.WriteLine("Mrs. Hilt used " + numberOfMarhsmallowsAllTogether + " marshmallos for her 5 Rice Krispie Treats.");



            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */

            int inchesOfSnowAtMrsHiltsHouse = 29;
            int inchesOfSnowAtBrecknocksElementarySchool = 17;

            int inchesMoreSnowatMrsHilts = inchesOfSnowAtMrsHiltsHouse - inchesOfSnowAtBrecknocksElementarySchool;
            Console.WriteLine("Mrs. Hilt house had " + inchesMoreSnowatMrsHilts + " more inches of snow than Brecknock Elemntary School.");


            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */

            int amountmoneyMrsHilt = 10;
            int amountmoneyToyTruck = 3;
            int amountmoneyPencilCase = 2;

            int amountmoneyLeft = amountmoneyMrsHilt - (amountmoneyToyTruck + amountmoneyPencilCase);
            Console.WriteLine("Mrs. Hilt has $" + amountmoneyLeft + " left.");

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int amountOfMarblesJoshhas = 16;
            int amountOfMarblesJoshLost = 7;
            int amountOfMarblesHasNow = amountOfMarblesJoshhas - amountOfMarblesJoshLost;
            Console.WriteLine("Josh has " + amountOfMarblesHasNow + " marbles now.");

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int amountofSeashellsMegan = 19;
            int amountofSeashellsDesired = 25;
            int amountofSeashellsneededForDesired = amountofSeashellsDesired - amountofSeashellsMegan;

            Console.WriteLine("Megan needs " + amountofSeashellsneededForDesired + " more seashells to reach 25.");

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */

            int numberBalloonsBradHas = 17;
            int numberRedBalloons = 8;

            int numberMoreGreenBalloonsBradHas = numberBalloonsBradHas - numberRedBalloons;
            Console.WriteLine("Brad has " + numberMoreGreenBalloonsBradHas + " more green balloons than red balloons.");


            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int numberOfBooksOnShelf = 38;
            int numberOfBooksMartaPuts = 10;

            int numberOfBooksInShelf = numberOfBooksOnShelf + numberOfBooksMartaPuts;
            Console.WriteLine("There are " + numberOfBooksInShelf + " books on the shelf now.");

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int numberOfLegsOnBee = 6;
            int numberOfBees = 8;
            int numberOfLegsOnXBees = numberOfBees * numberOfLegsOnBee;
            Console.WriteLine(numberOfBees + " Bees have " + numberOfLegsOnXBees + " Legs ");


            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double iceCreamConePrice = 0.99;
            int numberOfIceCones = 2;

            double priceOfXIceCreamCones = numberOfIceCones * iceCreamConePrice;
            Console.WriteLine(numberOfIceCones + " Ice cream cones would cost" + " $" + priceOfXIceCreamCones + ".");


            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */

            int needNumberOfRockstoComplete = 125;
            int numberOfRocksMrsHiltHas = 64;
            int NumberOfMoreRocksMrsHiltNeed = needNumberOfRockstoComplete - numberOfRocksMrsHiltHas;
            Console.WriteLine("Mrs. Hilt needs " + NumberOfMoreRocksMrsHiltNeed + " more rocks to complete the border.");


            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int marblesMrsHiltHas = 38;
            int marblesMrsHiltLost = 15;
            int marblesMrsHiltHasLeft = marblesMrsHiltHas - marblesMrsHiltLost;
            Console.WriteLine("Mrs. Hilt has " + marblesMrsHiltHasLeft + " marbles left");

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int milesAwayFromConcert = 78;
            int milesDrivenBeforeGas = 32;
            int milesLeftToConcert = milesAwayFromConcert - milesDrivenBeforeGas;
            Console.WriteLine("They have " + milesLeftToConcert + " miles left to drive.");


            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int minutesSpentShovelingSnowSaturdayMorning = 90;


            int minutesSpentShovelingSnowSaturdayAfternoon = 45;
            int minutesSpentInTotal = minutesSpentShovelingSnowSaturdayMorning + minutesSpentShovelingSnowSaturdayAfternoon;

            Console.WriteLine("Mrs.Hilt spent " + minutesSpentInTotal / 60 + " hrs " + minutesSpentInTotal % 60 + " minutes shoveling snow.");
            //Could probably arrange differently , but works


            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int numberOfHotDogs = 6;
            double priceofEachHotDog = 0.50;
            double priceforXHotDogs = numberOfHotDogs * priceofEachHotDog;
            Console.WriteLine("Mrs.Hilt spent $" + priceforXHotDogs + " on " + numberOfHotDogs + " hot dogs.");

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            double moneyMrsHilt = 0.50;
            double priceofPencil = 0.07;
            double howManyPencils = (int)(moneyMrsHilt / priceofPencil);

            Console.WriteLine("Mrs. Hilt can buy " + howManyPencils + " pencils.");

            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */

            int numberManyButterfliesSeen = 33;
            int numberOfOrangeButterfliesSeen = 20;

            int numberOfRedButterflies = numberManyButterfliesSeen - numberOfOrangeButterfliesSeen;

            Console.WriteLine("If Mrs. Hilt saw " + numberOfOrangeButterfliesSeen + " orange Butterflies, " + numberOfRedButterflies + " would've been Red.");


            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */

            double moneyKateGaveClerk = 1.00;
            double moneyCandyPrice = 0.54;

            double moneyChangeGetBack = moneyKateGaveClerk - moneyCandyPrice;
            Console.WriteLine("Kate would've gotten back $" + moneyChangeGetBack + " from the cashier.");



            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */

            int markNumberTreesBackyard = 13;
            int markNumberPlantsMoreMaybe = 12;

            int totalNumberOfTreesAfter = markNumberTreesBackyard + markNumberPlantsMoreMaybe;
            Console.WriteLine("Mark, after planting " + markNumberPlantsMoreMaybe + " more trees has, " + totalNumberOfTreesAfter + " in his backyard.");


            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int daysUntilJoySeesGrandma = 2;
            int hoursUntilSheSeesGrandma = daysUntilJoySeesGrandma * 24;
            Console.WriteLine("It will be " + hoursUntilSheSeesGrandma + " hours until Joy sees Grandma.");


            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int numberCousinsKimHas = 4;
            int giveEachFivePieces = numberCousinsKimHas * 5;
            Console.WriteLine("Kim would need " + giveEachFivePieces + " pieces to give 5 pieces of gum to each cousin. ");

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            double amountMoneyDanHas = 3.00;
            double amountMoneyCandyBar = 1.00;

            double amountMoneyThatIsLeft = amountMoneyDanHas - amountMoneyCandyBar;
            Console.WriteLine("Dan would have $" + amountMoneyThatIsLeft + " left.");

            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */

            int numberBoatsInLake = 5;
            int numberOfPeopleInBoat = 3;
            int numberOfPeopleInTheLake = numberBoatsInLake * numberOfPeopleInBoat;
            Console.WriteLine("There would be " + numberOfPeopleInTheLake + " people in the lake.");

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int numberOfLegosEllenHas = 380;
            int numberofLegosEllenLost = 57;

            int numberOfLegosRemaning = numberOfLegosEllenHas - numberofLegosEllenLost;
            Console.WriteLine("Ellen has " + numberOfLegosRemaning + " legos remaining.");


            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */

            int numberOfBakedMuffins = 35;
            int desiredNumberOfBakedMuffins = 83;
            int howManyMoreMuffinsToReachDesired = desiredNumberOfBakedMuffins - numberOfBakedMuffins;
            Console.WriteLine("Arthur has to bake " + howManyMoreMuffinsToReachDesired + " more muffins to reach " + desiredNumberOfBakedMuffins + "muffins.");
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int numberCrayonsWillyHas = 1400;
            int numberCrayonsLucyHas = 290;
            int numberMoreCrayonsWIllyThanLucy = numberCrayonsWillyHas - numberCrayonsLucyHas;
            Console.WriteLine(numberMoreCrayonsWIllyThanLucy +" More crayons Willy than Lucy");
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int numberStickersOnPage = 10;
            int numberPagesOfStickers = 22;
            int numberStickersInTotal = numberPagesOfStickers * numberStickersOnPage;
            Console.WriteLine(numberStickersInTotal + " Stickers.");

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */

            int numberOfCupcakes = 96;
            int numberOfChildren = 8;
            int numberEachSharedEqually = numberOfCupcakes / numberOfChildren;
            Console.WriteLine(numberEachSharedEqually + " If shared equally.");


            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int numberGingerbreadCookies = 47;
            int eachJarCapacityNumberCookies = 6;
            int numberOfCookiesNotPlacedJar = numberGingerbreadCookies % eachJarCapacityNumberCookies;
            Console.WriteLine(numberOfCookiesNotPlacedJar + " Not placed in a jar.");

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int numberCroissantsPrepared = 59;
            int numberOfNeighbors = 8;
            int numberOfCroissantsEquallyByEight = numberCroissantsPrepared % numberOfNeighbors;
            Console.WriteLine(numberOfCroissantsEquallyByEight + " Be left with Marian." );
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int numberCookiesAtTray = 12;
            int numberCookiesAtTime = 276;
            int numberTraysNeeded = numberCookiesAtTime / numberCookiesAtTray;
            Console.WriteLine(numberTraysNeeded + " Trays.");


            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int numberPretzels = 480;
            int servingEqualTo = 12;
            int amountServingsPrepared = numberPretzels / servingEqualTo;
            Console.WriteLine(amountServingsPrepared + " Servings has to prepare.");
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int numberOfLemonCupcakes = 53;
            int numberLemonCupcakesLeftHome = 2;
            int numberOfCupakesTotal = numberOfLemonCupcakes - numberLemonCupcakesLeftHome;

            int numberCupcakesInBox = 3;

            int numberCupcakesGivenAway = numberOfCupakesTotal / numberCupcakesInBox;
            Console.WriteLine(numberCupcakesGivenAway + " Boxes given away.");

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int numberPreparedCarrotSticks = 74;
            int numberServingToXPeople = 12;
            int numberCarrotsUneaten = 74 % 12;
            Console.WriteLine(numberCarrotsUneaten + " Carrot Sticks uneaten.");


            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int numberTeddyBears = 98;
            int numberMaximumTeddyBearsShelf = 7;
            int numberOfShelfsFilled = numberTeddyBears / numberMaximumTeddyBearsShelf;
            Console.WriteLine(numberOfShelfsFilled + " Filled Shelves.");

            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int numberOfPicturesInAlbum = 20;
            int numberOfPicturesForAlbum = 280;
            int numberOfAlbumsNeeded = numberOfPicturesForAlbum / numberOfPicturesInAlbum;
            Console.WriteLine(numberOfAlbumsNeeded + " Albums needed.");

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int numberOfTradingCards = 94;
            int numberOfMaximumCards = 8;
            int numeberOfBoxesFilled = numberOfTradingCards / numberOfMaximumCards;
            int numeberOfCardsUnfilledBox = numberOfTradingCards % numberOfMaximumCards;
            Console.WriteLine(numeberOfBoxesFilled + " boxes filled." + numeberOfCardsUnfilledBox + " cards in unfilled box.");
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */

            int numberBooksToRedistribute = 210;
            int numberShelves = 10;
            int numberBooksContainedEachShelf = numberBooksToRedistribute / numberShelves;
            Console.WriteLine(numberBooksContainedEachShelf + " Books remaining each shelf." );
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int numberCroissants = 17;
            int numberGuests = 7;

            int eachGuestHowManyCroissants = (int) (numberCroissants / numberGuests);
            Console.WriteLine(eachGuestHowManyCroissants + " Each have.");
         /*
             CHALLENGE PROBLEMS
         */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */
         double timeBillHrs = 2.15;
            double timeJillHrs = 1.90;
            

            double timeBothHrs = timeBillHrs + timeJillHrs;
            double timeBothCombinedHours = (timeBothHrs / 2 /2) ;


            double timeForFiveRooms = Math.Round(timeBothCombinedHours * 5);

            Console.WriteLine("It would take " + timeForFiveRooms + " hrs for both, Jill and Bill to Paint, 5 12 x 24 Rooms." );
      
            double timeForSixTwoThreeRooms = timeBothCombinedHours * 623;
            double hoursforrooms =  Math.Round(timeForSixTwoThreeRooms / 8, 2, MidpointRounding.AwayFromZero);
           
            Console.WriteLine("It would take " + hoursforrooms + " days for both, Jill and Bill to Paint, 623 12 x 24 Rooms.");


            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */

            var name = "Juan";
            var lastName = "Leon, ";
            var middleInitial = " A.";

            var fullName = lastName + name + middleInitial;
            Console.WriteLine(fullName);



            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */

            decimal distanceBetweenNYandChi = 800;
            decimal trainTraveledAlready = 537;
            decimal percentageTripCompletion = Math.Round((100 * trainTraveledAlready) / distanceBetweenNYandChi);

            Console.WriteLine(percentageTripCompletion + "% of the trip was completed.");




        }
    }
}
