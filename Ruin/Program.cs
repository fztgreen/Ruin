﻿// See https://aka.ms/new-console-template for more information
using Ruin.Creatures;

Attack Punch = new Attack ("Punch", "A quick jab, thrown with an unarmed hand.", 1, 4, AttackType.Bludgeoning);
Attack Haymaker = new Attack("Haymaker", "A massive punch, thrown with an unarmed hand.", 1, 6, AttackType.Bludgeoning);
Attack Stab = new Attack("Stab", "A quick stab with a dull blade.", 1, 4, AttackType.Piercing);
Attack Puncture = new Attack("Puncture", "A precise stab with a sharp blade.", 1, 6, AttackType.Piercing);
Attack Nick = new Attack("Nick", "A quick swipe with a dull blade.", 1, 4, AttackType.Slashing);
Attack Slash = new Attack("Slash", "A clean slice from a sharp blade.", 1, 6, AttackType.Slashing);
Attack Firebolt = new Attack("Firebolt", "A small bolt of fire that burns a target.", 1, 6, AttackType.Fire);
Attack Incinerate = new Attack("Incinerate", "A growing flame that engulfs the target in fire.", 2, 12, AttackType.Fire);
Attack PoisonSpray = new Attack("Poison Spray", "A sickening cloud of poison clouding that builds up poison.", 1, 4, AttackType.Poison);
Attack Infect = new Attack("Infect", "A vile infection that massively raises poison levels.", 2, 8, AttackType.Poison);
Attack Chill = new Attack("Chill", "A chilling blast of cold that numbs and freezes.", 1, 6, AttackType.Cold);
Attack Frostbite = new Attack("Frostbite", "A frigid blast of bitter cold that numbs and freezes.", 2, 12, AttackType.Cold);
Attack Arc = new Attack("Arc", "A crackling arc of lightning that shocks the target.", 1, 12, AttackType.Lightning);
Attack LightningBolt = new Attack("Lightning Bolt", "A crackling bolt of lightning that electrocutes the target.", 2, 24, AttackType.Lightning);
Attack ArcaneBolt = new Attack("Arcane Bolt", "A simple blast of magic that damages and regenerates mana for the caster.", 1, 4, AttackType.Arcane);
Attack MagicMissile = new Attack("Magic Missile", "A focused burst of magic that damages and regenerates mana for the caster.", 2, 8, AttackType.Arcane);

Console.WriteLine("Generating Creatures...");
Creature Creature = new Creature("Creature", null, null);
Creature.displayCreatureStats();

//Creature Creature2 = new Creature("Creature 2", null, null);
//Creature2.displayCreatureStats();

//Creature Creature3 = new Creature("Creature 3", null, null);
//Creature3.displayCreatureStats();

//Creature Creature4 = new Creature("Creature 4", null, null);
//Creature4.displayCreatureStats();