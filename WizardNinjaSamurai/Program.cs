Wizard w1 = new Wizard("Merlin");

w1.ShowInfo();

Ninja n1 = new Ninja("Donatello");

n1.ShowInfo();

Samurai s1 = new Samurai("Oni");

w1.LifeDrain(n1);

n1.Shuriken(w1);

s1.Disembowel(n1);

w1.ShowInfo();

n1.ShowInfo();