#define trig 10
#define echo 9
#define Led 2

void setup() {
  Serial.begin(9600);
  pinMode(trig,OUTPUT);
  pinMode(echo,INPUT);
  pinMode(Led,OUTPUT);
  digitalWrite(Led,LOW);
  digitalWrite(trig,LOW);
}

void loop() {
  digitalWrite(trig,HIGH);
  delayMicroseconds(10);
  digitalWrite(trig,LOW);

  unsigned long tempo = pulseIn(echo, HIGH);
  int distanza =  0.03438 * tempo / 2;

  Serial.print(String(distanza) + ";");

  if(distanza < 10)
  {
    digitalWrite(Led,HIGH);
  }else{
    digitalWrite(Led,LOW);
  }

  
  delay(1000);

}
