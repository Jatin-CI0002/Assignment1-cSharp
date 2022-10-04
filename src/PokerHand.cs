
namespace Assignments
{
    public class PokerHand
    {
            public static string PokerHandRanking(string[] hand)
            {
                List<int> values = new();
                List<string> suits = new();

                foreach (string card in hand)
                {
                    string suit = card[card.Length - 1].ToString();
                    string value = card.Substring(0, card.Length - 1);

                    switch (value)
                    {
                        case "A":
                            value = 1.ToString();
                            break;
                        case "K":
                            value = 13.ToString();
                            break;
                        case "Q":
                            value = 12.ToString();
                            break;
                        case "J":
                            value = 11.ToString();
                            break;

                    }
                    values.Add(Convert.ToInt32(value));
                    suits.Add(suit);

                }

                if (RoyalStraightFlush(values, suits))
                    return "Royal Flush";

                else if (StraightFlush(values, suits))
                    return "Straight Flush";

                else if (FourOfAKind(values))
                    return "Four Of A Kind";

                else if (ThreeOfAKind(values) && Pair(values))
                    return "Full House";

                else if (Flush(suits))
                    return "Flush";

                else if (Straight(values))
                    return "Flush";

                else if (ThreeOfAKind(values))
                    return "Three of a kind";

                else if (TwoPair(values))
                    return "Two Pair";

                else if (Pair(values))
                    return "Pair";

                else
                    return "High Card";
            }

            private static bool RoyalStraightFlush(List<int> values, List<string> suits)
            {
                var orderedValues = values.OrderBy(val => val).ToList();
                bool result;
                if (orderedValues.Any(val => val == 1) && orderedValues.Any(val => val == 13) && suits.Distinct().Count() == 1)
                {
                    orderedValues.Remove(1);
                    result = !orderedValues.Select((i, j) => i - j).Distinct().Skip(1).Any();
                    return result;
                }
                return false;
            }

            private static bool Flush(List<string> suits)
            {
                if (suits.Distinct().Count() == 1)
                    return true;

                return false;
            }

            private static bool StraightFlush(List<int> values, List<string> suits)
            {
                var orderedValues = values.OrderBy(x => x).ToList();
                if (!orderedValues.Select((i, j) => i - j).Distinct().Skip(1).Any() && suits.Distinct().Count() == 1)
                    return true;

                return false;
            }

            private static bool Straight(List<int> values)
            {
                var orderedValues = values.OrderBy(x => x).ToList();
                bool result;

                if (orderedValues.Any(x => x == 1) && orderedValues.Any(x => x == 13))
                {
                    orderedValues.Remove(1);
                    result = !orderedValues.Select((i, j) => i - j).Distinct().Skip(1).Any();
                    return result;
                }

                if (!orderedValues.Select((i, j) => i - j).Distinct().Skip(1).Any())
                    return true;

                return false;
            }

            private static bool FourOfAKind(List<int> values)
            {
                foreach (var value in values.Distinct())
                {
                    var counter = 0;
                    foreach (var rest in values)
                    {
                        if (value == rest)
                        {
                            counter++;
                            if (counter == 4)
                                return true;
                        }
                    }
                }
                return false;
            }

            private static bool ThreeOfAKind(List<int> values)
            {
                foreach (var value in values.Distinct())
                {
                    var counter = 0;
                    foreach (var rest in values)
                    {
                        if (value == rest)
                        {
                            counter++;
                            if (counter == 3 && counter < 4)
                                return true;
                        }
                    }
                }
                return false;
            }

            private static bool TwoPair(List<int> values)
            {
                var pair = 0;
                var counter = 0;

                foreach (var value in values.Distinct())
                {
                    foreach (var rest in values)

                        if (value == rest)
                            counter++;

                    if (counter == 2 && counter < 3)
                        pair++;

                    counter = 0;
                }

                if (pair == 2)
                    return true;

                return false;
            }

            private static bool Pair(List<int> values)
            {
                var pair = 0;
                var counter = 0;

                foreach (var value in values.Distinct())
                {
                    foreach (var rest in values)
                        if (value == rest)
                            counter++;

                    if (counter == 2 && counter < 3)
                        pair++;

                    counter = 0;
                }

                if (pair == 1)
                    return true;

                return false;
            }

            private static string HighCard(List<int> values)
            {
                if (values.Contains(1))
                    return "A";

                else if (values.Contains(13))
                    return "K";

                else if (values.Contains(12))
                    return "Q";

                else if (values.Contains(11))
                    return "J";

                else
                    return values.Max().ToString();

            }
        }
    }
