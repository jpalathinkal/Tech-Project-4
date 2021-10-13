using System;



namespace Tech_Project_4

{

    class Program

    {

        static void Main(string[] args)

        {

            const int number = 8;

            const int suit = 4;

            string[] cards_number = new string[number] { "A", "K", "Q", "J", "T", "9", "8", "7" };

            string[] cards_suit = new string[suit] { "S", "H", "D", "C" };

            int[] dominant_number = new int[number] { 11, 4, 3, 20, 10, 14, 0, 0 };

            int[] non_dominant_number = new int[number] { 11, 4, 3, 2, 10, 0, 0, 0 };



            // Input 

            Console.WriteLine("Enter the number of hands and suit with a space between: ");

            string user_hand_and_suit = Console.ReadLine();

            int space_index = user_hand_and_suit.IndexOf(" ");

            int number_last_index = space_index - 1;

            int suit_index = space_index + 1;

            string hands_string = user_hand_and_suit.Substring(0,number_last_index).ToString();

            int hands = int.Parse(hands_string);

            string dominant_suit = user_hand_and_suit[suit_index].ToString();



            try

            {

                if (hands >= 1 && hands <= 100)

                {

                    int number_of_cards = hands * 4;

                    int index = 1;

                    int total_points = 0;

                    while (index <= number_of_cards)

                    {

                        Console.WriteLine("Enter a card value");

                        string current_card = Console.ReadLine();

                       

                        string current_card_number = current_card[0].ToString();

                        string current_card_suit = current_card[1].ToString();

                        if (Array.IndexOf(cards_number, current_card_number) != -1)

                        {

                            if (Array.IndexOf(cards_suit, current_card_suit) != -1)

                            {

                                if (current_card_suit == dominant_suit)

                                {

                                    int dominant_number_index = Array.IndexOf(cards_number, current_card_number);

                                    int dominant_value = dominant_number[dominant_number_index];

                                    total_points += dominant_value;



                                }

                                if (current_card_suit != dominant_suit)

                                {

                                    int nondominant_number_index = Array.IndexOf(cards_number, current_card_number);

                                    int nondominant_value = non_dominant_number[nondominant_number_index];

                                    total_points += nondominant_value;

                                }

                            }

                        }

                        index += 1;

                    }

                    Console.WriteLine(total_points);

                    Console.ReadKey(true);

                }

            }



            catch

            {

                Console.WriteLine("Please enter new cards or new initial line information");

                Console.ReadKey(true);

            }

        }

    }

}