double speedOneFreand = 5;
double speedTwoFreand = 10;
double speedDog = 20;
double distance = 100;
double distanceLimit = 10;
int dogCount = 0;
int dogDirection = 1;
double speedOll = 0;
double time = 0;

while (distance > distanceLimit)
{
    if (dogDirection == 1)
    {
        speedOll = speedOneFreand + speedDog;
        time = distance / speedOll;
        distance = distance - speedOll * time - speedTwoFreand * time;
        dogDirection = 2;
        dogCount++;
    }
    else
        speedOll = speedTwoFreand + speedDog;
    time = distance / speedOll;
    distance = distance - speedOll * time - speedOneFreand * time;
    dogDirection = 1;
    dogCount++;
}
Console.WriteLine($"Собака сделала {dogCount} круга");