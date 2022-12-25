//INACABADO

yte led[4] = {1, 2, 3, 4};
byte button[4] = {6, 7, 8, 9};
byte aleat[100] = {};

int var1 = 0;

void setup ()
{
  for (byte i = 0, i < 4, i++) {
    pinMode (led[i], OUTPUT);
    }
  for (byte i = 5, i < 10, i++) {
    pinMode (button[i], OUTPUT);    
    } 
     randomSeed(0);
  }

void loop ()
{
  var1 += 1; 
  }

void GerarAleat()
{
  aleat[var1] = random(1,4);
  }

void loop ()
{
  if (byte aleat[i] = 1)
  pinMode (led[1], INPUT);
  }
