using DailyChallenges;

ChallengeRepository _cr = new ChallengeRepository();


string input = "I Know you are, but what am I?";
string output = SpongebobCase(input);
Console.WriteLine(output);

List<float> measurements = new List<float>(){ 1.3f, 3.23f, 0.1f, 2.5435f, 100.2f};
Console.WriteLine(_ck.ConvertToKm(measurements));

_cr.AnimalOrFood();

