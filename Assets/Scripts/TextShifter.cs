﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextShifter : MonoBehaviour {

	string[] zalgos;
	float timer;
	// Use this for initialization
	void Start () {
		timer = 0;
		zalgos = new string[]{"H̨̛͎̩̤̳̫̻͕͎͉̫̼̞͔̹̙̥͌̅̽̊͛̽̇̀̓̎͊̔͆̈́͊̇ͫ̚͝I̺͍̠͓̤̭̹̰̊̋͗ͩ͌͌ͬ͋ͮ̓ͬͫ̈͌͌͛͑ͣ͐̀͠͡ͅV̘͍̘͉̠̇̄͋͋̉̈́̈́̂ͨ̄́̕Ě̎́ͫ͋̿́̀͏҉̛̖̯̮͍̝̫̙̘̥̯̟̟̰̤͚͎M̴̏͐̇̾͗̒̅̇̈ͪ̆͜҉̩͚̹̼̳̼̼͍͓̻̯̣͇̮̹͖I͒ͪͪ͂̿̓͆́҉͏̺͚͙̲͍͖̗̬̼̗̙̠̝͖͔ͅNͦ̆ͭ͊ͧ̃̋̄҉͓͢ͅͅD̨͖͙̙̳̙͖͇̙͉̣̟̼̥͈̓ͩͧ̆̈̚̕͟͠",
			"\nH̶̨̹̥̮̱̗̙̣̹̹̖̲͕̘̥̠͓̗̭̮͑͌̓͌͛͋̽͐ͪͯ͂ͫ͋ͦ͢͝I̸̴̯̬̟̪̻̙̱̖̐ͯ̑̽ͦ̐̌̑͑ͤ͛͆͐̽͢V̡̧̛̩̩̘͙͉̫̙̻͌͂̒̾̃̆̈́ͪ̐͐ͯ͘͠ͅẺͨ͗̓͌ͧ͑͟҉̣̞̣̤͈̻̳͈͍M̨ͪ͗͗̓̆̇̃͋ͤ̌̅͏̵̞͙̘̺̲͍̣̣̰̻̳͔̰͔̯ͅͅỈ̧͎̪̙̜̺̣͖̪̩͌ͯ̈́̏̑͆̋ͭ̋ͩ̇̍̎ͩ̊ͧͫ̀͠͡N͐̎ͣ̿̔̊̌̏͋͑͜͜҉̧̖͎͙͔̥̪̠̱͙̜͖̗͉ͅD͇̼̻͖̘̗̠̙͉̹̭͈͕͈̼̈́̇͌̎ͬ̈́͒͟ͅ",
			"H̶ͤ̓ͫ̐̏͂͋ͣ͛̀̇̑ͧ̂̈́̽̀҉͏̟̻̻͖̯̩̥̮̣͖͈͙̘̼̻͡I̿ͬ̊̄ͦ̍̂̌ͮ̄҉̷͈̟̤͕͓͕̬͈̀̀V̶̵̨̾ͤ̀̇͐ͧ̉͌̏́͗ͨ̇ͭͥͧ҉̭̜̹͕͚̰Ȩ̵̢̗͈̠͔̰̺͖͕͕̫̘̒͊ͩ̿ͪ̈̐̊̍̄͘M̶̷̩͙̰̬̦̮̩͔͖̓ͭ͒ͨ̏͊ͤ̓̒ͩ̇̓́̿̚͘͢͞Ḯ̜̱̰̪̳̮͚͖̪͇̜̯̦̙̜̹ͯ͊ͦͧ̎̈́̀̕͘N̔̔̽̒̃̚͏̫̥̞́D̩̼̞̖̺̞̼̯͙̣̹͍ͬͮ̅̔̏̏́͒͜͝",
			"\nH̟̰͈̎ͦ͐̒̆ͨͥ̊ͥͨͮͨ̓ͥ̋̑͋̀͝ͅI̺̻̯̻̮̘̥̫̜̫ͮ̓ͮͯ͋̏́̚͡͝ͅV͖̞͎̗͇̮̖͚̜ͭ̊̐̑̐͊́̎ͧ̅̆̈͠E̶̴̯̩̙̞̜̞̓̈́̿̍ͯ̍́̎͑ͥ̚̕ͅM̴̷̶̨̬͎͕̖̺̮͓̠̯̖͙͓̟̠ͯ̓͊̾̅̽̅̎̌̕I̙̦̞̟ͣ̃̄͜͟͝N̶̛̛̍̃̿̓͑̎ͬͦ̑̅̈́̍̿͗̓͑͏͕͈̱̭̰͡ͅD̯̟̯̙̊̾̃̓̉̌̃͑́ͥ̀̐̎̆͋͜͢͝",
			"\nH̶̢͕͚͔̳͚̱̻̹̩̼̗̗͓̙̺̫͔̯͇̑ͪ̀̔ͬ͐ͦ̈́͗͒̌̒͆́̀̚Ȉ̡̛̳̹͕̻̟̝̮͙̺̜͇̻͕̮͎̮̑̅̍̃̍V̡̡̯̱̘͎̗̟̦̺͇̮̈̌̈̒̀ͥͣ̏̄͞ͅȨ̎̌͒̽̎̂̍̓̓ͩ̅͒̏҉̵͏̩̪̪͙̠̜̫̣͓̖͍ͅM̷̈̈ͩͨͯ̽͛́ͩ̓ͣ̌̍̃̋ͣ͞҉͏̡̝̩̠͎͚̘ͅĪ̢̢̢̖͎̟̘ͩͮ͑̍̐͋̓̔̎̈͒ͪ̐ͬͥͯ̚͘N̸̗̤̦̜̮͙͕̞̝̞̬͙̫̞͇̱̦ͭ̓ͨ̏ͬͯ̈́ͦ͐ͧ͐̽̍̍ͭ͂͞D̵̨̛̼̞̜͖͒̋̉ͫͯͨͨͮ͒̔ͣ̉ͧͥ̋̚͠",
			"\nH̢͔̳͉̲̟͈̳͌̉͌̉̎͐͐ͣ͒ͭͯͭͪͫ̓͗̄͐̓̕͠I͓̠̰͎̩̥ͤ͋͊̆͛͆̌̍̉ͦ͛ͩ͐ͪ͆͘͢V̴̺̥͍̤̟͙̰̙͎̠̯͚͈̦͂̀͒͂́ͮ̅́͡͝͝E̵̵͖̳̭̝͓͕̥̝̥̲̞̯̼̰̐̉̊̇̽̈͆̆̒ͭͪ̌͂͒ͭ͌̎ͪ̚͝M̷̳̭̯̘ͭ̉ͣ̐͒̕͞I̶̡̿ͬ̈́͒͐ͯ͆ͫ̏͊ͪ̿ͩ̌̓ͤ͂͢͏̘͇̹̟̖͚͎̰̮̘Ṉ̤͎͎̭͚̤͍͇̗ͨ́́̎̓̓̃ͧͣ̚̚͠D̢͚̻̩̲̙̞̫̣̙̩͍̠̗̭̹͇͖͓ͩ̌̄̎ͥ̏̐ͩ̏̔ͬ͌̒͂̀͟ͅ",
			"\nH̶̡̟̩̬͙̞͚̙͍͍̯͓ͨ͋͂͒͌ͯͥ̄̓ͫ͌̈̃͌̃͢͠I̛̦͙͖͙̯̣͔̬͇̒̂ͮ̔͛̐ͨ̐ͬ̂̿̆̕ͅV̛̠̦̦̩͓̖̩̻̓̿͂̇ͭͯ̌̓̓̀́̒̈́̓ͦ͆́̚͜ͅE̸̷̬̳̫͈̤͇͚̟͇͇̲̍̋ͩ͒̉̀ͅM̡̖̹̩̭̪͈̖̺̰̲̟̳̰̺̘̯͊̑̇̇̿̒I̛͈̖̺͍̔̅͆̂̾͊͊̈́͜͝N̛͍̭͈̠͉̥̼̯͓̰̯̍ͬ̽̔ͧ̆̽ͩ͛͟͜D͆̃ͥ̀̔̋ͭͬͪͪ́̚҉͜҉̯̗̞͈̘̦͍̖̥͇̖̙ͅ",
			"hͣ̈́ͥͥ̿ͮ̿͋͘͏̟͇̺̰͇͎͈͎̹̟ͅi̸̧̯̭̟̙̱͖̼̓̓̿̔ͮ̉̽̅͌̽̀̚͜ͅv̢̟̭͎͇͈̹͕̘̣̺͋̑͛͑͒͐́ͤ̇͑͒͌ͫͦ̋̎ͤ͘͟͠e̢͍͎͙͔̥͉̗̔ͮ̃̇̃̀ͯ͐͂̌ͧ͡ͅḿ̵̋̏ͬ͗͌̏ͩ̄͞҉̧̰͉̫̗͖͈̘̦̘̭̲̦̳̥̯͎̖͔͡i̷̷̧̠͖̝̜͚͖͖̞̤̗͓ͬͯ̽̓ͩ͂ͫ͌̓ͧ̏ͪ̆̔ͥ̑̚n̴̶̻͓͈̳̥̘̻̭̻̭͓͉̦ͨ̄ͧ͒͗͐̍͐̊͊͗̓́͜͢ͅd͍̬͇ͦ̊̉͌̚̕͝",
			"\nḩ̸̡̱̙̫̩̣̹͉̭̻̻̳̖̠͇͍͛̀̏ͤ̏ͭ͋̍̾̎̕i̸͈̜̥̤̜ͩ̾ͪͬͮ͐͂͋̎̀́͘͝v̢̡̲̖͍͇̗̗̮̬̼̗̟̳̳ͫ̔̇͐ͨ͌͆͊͆̏ͬͦ͊́̚͠e̷̻̖̹͍̘̲̹̮̜̬ͣͩ̿̆́̋̆͐͛̎̈́̌̿ͦͤ̄ͤ̀͜͠m̷̛͖̭̞͔̼̪͉ͯͪͣ́̑̾͋̄ͫ̋̑̍ͫ̇́į̡̧̮̖͚͎̦̮ͧ́̂͐̏̌͑ͩ̈̽͛̔̀͑ͨ̇̂̒̽͢͝ņ̛ͪͤ̓͌ͮ͆͏̫͔̰̰̮̞̤͈̤ͅd̜͉̮̪̠͎̺̜̻͎̬͚̗̜̯̣̪̫̒̾͗͋͒ͬ̍̊ͩ̎͛͆͂͂́̚̚",
			"h̿ͫ̇͊̀́҉̸̹̤͙͙̖͉̗͉̠̳͇̥̞̼̫̱̀i̵̡̻̗̺͍̯̥͇̦̘͓̳͔͓͚̯̬̝̞͎ͭͧͬͭ̈̂ͬ̓̔̋̊ͯv̛̿ͪ̊͛̌̄̃ͣ̇҉͔̜̜͖̣͈̝̀ę̴̬͓̹̦̮̪̜̯̹̬̅͌͊͑̅̔͌̈́̃́͠ͅm̷̶͚̦̥͙̗̪͉͍̐̓̾͑̉̀̅ͯ̽͠į̞̼̹̜̦̣͓͉͍̟̪͉̿̅͐̌́̔͂̉̆́̑̍̚͟n̷̢̻͕̞͖̝̖͖̹̪̠̜̩̒̾ͬ͐ͩͦͪ̍̏̂ͬͫ͊̈́̌͋͑̀͟ͅͅd̨͉̤̝͇̼͓̿͆̐ͭͣ̐ͤ̉̏ͣͮ̽̆̈̔ͦͅͅ",
			"h̛ͯ̽̈́̿̀͊ͯ͌͆ͮ̐҉̘̭̩͇͕̫͔i̧̢̙̟͇̳̒̅͒̔̊̓͆̑ͯ̎ͩ̋̋͟͢͠v̸̹̪̖̣̖̭͖̺͙͒̇͂̉̐͆ͫ̓̿ͥ͐ͨ̈́ͭ̊ͧ͌͞ͅe͚͉̹̖͈̭̤͕͇͎̫̙̳̝̫ͦͩ̐͌̓̃ͨ̈̎͒̊̆̑̂ͤ͢͠m̷̨̜̺͓͔̼̥̬̼̘͎̻̯̪̳̺͉̻ͩ̑͊ͮ͆̈́͗͂ͬͤͪͪ̔̚͝i̷̧̦̖̰̲̹̗̭̯̝̞̟̞̥̭̾̾͛̚n̘̹̜̫̘͓͚͓̫̝̞̹̜̩͒̆ͦ̔̉ͬ́̂̿ͥ̀͜͝ͅd̸̴̢̼̫̣̙̜̙̫̉̽̎ͨ̍͑͌͝",
			"\nḩ̨̺̩̯̥̥͎̘̠̫͈̗̺̮̼ͫͪ̀ͪͥ̆̉͊ͩ̿̋̀̕͟ͅi̴̢̤̻͖͉̘̭̞͓̱̻̫͖̜̯̬̱͕̹ͥ͐́̓͊̑̂̑̿ͮͥ̀̀͟ͅv̶̷̢̪̥͓̙̟͇̯͈̻̬͍̘̯̯̦̪͎̞̮̇͌͒̆̿̂͞e̞͚̬̗̺͎̫̟̻̟͇̪̲̩̪̾̏́͡m̲̦̲͈̺̘̼̣̪̞͙̭̟̋̅͛̔͂̏̋̅̌͗̍ͥ͜͢͟i̧͙͚̠̹͖̟̳̭̘͈̙̜͉̪̻̲͑̅͆̈͠͝n̨̡̡̗̼͍̜̫̖̞̼̠̻̥̭̖̤͚̣͆̑ͥ̉̂͌͒̏̒ͣ̆̅ͫ̉̆͆̾̀̚͢ͅd̍̿̃̓̓͌ͯ҉̬̻̟̀̕ͅ",
			"\nȟ̛͎̘͍̂̐ͩͥͬ̑ͯ͑ͥͪͣ͗ͮ͌̈̀̀͢i̸͔̭̹̗̬ͧ̓ͣ̋ͧ̀ͩ̀͛͐̄̕͢͢vͧ͐̂̈̑̅҉͏̬͖̞̰̳̹͎͎͙͙͠͝ͅͅͅë̷̻̳̘͖̰̳̯́̎̾ͧ̆͊̉͜ṃ͕̦͉͕̟ͥ̍ͪͮ̇ͯ̆ͬͫ̀̒̅̈́̀̓̍͠ī̷̞͙̦̬ͣ̉͐̃̇̃̂ͩ͒̂͒͂̒̑̚n̛͆̑̍̈́̋̏ͤ̎̓̋ͯ̚͏̨̨̱̠͖̠̤̦̰̗̤̘͖͡ͅd̢͉͚̰͔̯̘͚̺͍̥̠̦̙̃͋̿͛̎͋͊͊̽̓͆́͛̃ͨ͘͝͞",
			"\nḥ̴̗̞̯̬̥͚̟̳̲̠̥̪̆̋̓̿ͫ̓̅̌̍̏̂̄̚͡͠i͊̔̏ͫ̔̆ͤ͌͆͐͛ͥͬͧ͛̽̔́͆͏̴̡͎̪̫̯͎͙̺͎̲̣̭̙̥̀͡v͕͓̱̯̟̬̭ͯ̓͂͊͡͡e̍̈́̍̃̐̅ͭ̃̿̔̉ͥ̈̂́͏̨͖̝̞̝̯̜͚̥̀ͅm̛ͦ͒̇̏͛̑ͦͯͤͯ̎̉̏͆̀̉ͯ̕͏̡͙̼͔̰͔͉͔͢i̓̿ͩ̅ͤ͊̆̓͋͊̉͆͂͆ͤ̾҉̷̨̦̜̲͚͎̭̪̲̲͖̺͕̙̬͞͡n̶̷̴̨̹̭̤͙͍̩͙̠̙̥̱̘̻̗͚͕̩̓̊̎ͤ̀d̡̺̰̥͕̹̙̹͖̃͑̾̾͒̔̇ͪ̾́ͅ",
			"h̡̨̢̦̘̣͙̜͕͎ͤ̓͂ͧ̃ͮ̑̒͊͛͒͐̋̃̒͝į̡̛̘͕̗̪̪͚̲̲͎̿̄̎̉̆ͭ̃̎ͬ̅̐ͪ̐̎ͥ͊̌̚̕͠v̸̢̭͈͚̘̙̩̜̠͙̻͖̗̩̺͍ͪ̓͒͒̓̏̉̌ͫ̾͗ͫ́ͬ̊̓̓̈́̀ͅe̊̍ͪ̇̃̆҉̷̪͓͖̰̲͖͙̭͕͍͙̤̺̦̟͙͔͈̞m̵̥̝̞̹͙͓͚̫̥͖̗̱̟̗͖̋̑ͯ̆̑ͥ͛͒͢͡i̛̺̝̭̦̐͒͑͆̑ͦ̓ͩ͛̆͊̎̇͋͊̚̚̕͟n̵̰͕̺̩̞̱̘̝̫͓̱̟̻̱̙͗ͥͥͮ̓͑ͩ̓̓̂̽ͣ̑d̆ͦ̔̏͆͒͛͘͡͏̵͚̗̞͔",
			"\nh̨̨͈̼͉͍̬ͥ̍ͪ̂͐ͧ͛͗ͮ͂̃̎̋̒̋̋̒͘͢͠i̷̬͉͍͓͎̮̫̩͓͙̲͌̅̀͑͗͜͜v̡̥͕̭̩̬̣̱̬̦̤͚̺̹͓̫͚͉ͭ̐͒̀͗͟͝e͒̉ͣͪͤ̐̽̈́̉̈ͩ̔҉̢̢̼͇̖͙̲͖͈̦̳̲̣͇͝͝M̂̊͌ͭͫ̅̓ͭ̑̒̑ͤ҉̦̗̪̮͕̜̹̼̖͖̙̩̭̜̫͘͡I̷̢ͯ͒̐̂̀̋ͩ̊ͪ̄͗͗̐̉̈̃̿҉̷̩̺̩͕̫̟͕̩̭̲͚̗̤̗͕̜̭̻̞N̳̩̥̺̬̥̤͉̺͇̺̝̯͕̞̉͌ͬ̓̈́ͨ̄́͆ͣ͗̔̓͛̅̓̔̉̕ͅĎ̵̛̮̺̘̗̖̹̜ͤ͂ͮ͆͂̍̀͑͑̈̉̇̾ͣ̋̿ͣ",
			"\nḧ̴̴̢̼̬͖̹͔̜̫̠ͬ͆ͥ̿̅̓̄ͨi̢̖͚̥̜̰̟͈̯͇͛̒͊͊ͤ̉ͭͧͯ̾́ͧ̅͒̈͐̔ͨ́̕͜͡v̡̛̥͖̗̲͚͎͎̋̔̄͐ͭ̃͆̍̌̏͐̍͛ͪ́͢͝ͅͅȩ͚̯̠̲͔̤̮̿̎̒̈́̿̍ͮ̽͊ͦ̾́̕͟͝ͅM̧̫̗̬͚̟̦̹͕̰͙͍̃͛̀̎̒ͨ̾͛̓̐ͤ̏̓́̚Ȉ̶̼͔̠̩̬̞̤̗̙̜̏̓ͮ͒ͨͨ͗̉ͩͦ̈̚Ń̸̺̰̠̗̘̄̇͗ͦ̂̈́͌͗ͧ͢͝͝D̡̟͖̙̼̙͔͗̊͗̊́́͗̽ͨ́",
			"H̦̱̼̬̝̙͙͖̣͔͈͙̘̪̗̮̓̔̿ͬ͛ͫ͗̀̚͘͟͞ͅĮ̨͈̥͖̯͖̘͙̞̥̞̼̻̤̱͚̬͍ͦͮ̈͐̄̎́ͬͧͦ̍̋́͟V̧ͯ̑̈́̄͂̀͐̊͂̈́͊͏͓͓̫̪̠͔͖̪̙̜̝̱̱̼̣̗̖͓̠É̷̂̾͒͏̠͚̩̙̝͇̺̦̫m̷̺̝̹̻͈͉̖̬̀̄͌͂ͮ̀́͞i̴̸̡̢̦̜͕̟̜̲̮̥̘̬͇̳ͯ͛ͫ͘ͅn̜̮̣͕̳̰͍̮̯͈̣̍̂̏̉ͤ̐̌͋̓̀̀͟͝d̵̷̡̘̹͈̼̼̜̭̣̣̼̗̝͉̥̺͔͎̮̙̄̓̒̏̅̚͞",
			"T͔̱͖͎̜̦͖͍͎͎̼ͧͥ̆͌͌̒̉̿ͨ͑͐ͬ̍ͯ̂̅̍̚̕͜͢͡ͅH̸̋ͭͥ̉̔͆̆̌͡͏̨͍͖̺͈̼̻͔̫͍͔̙̙͝ͅE͉̜̤͚͚͎̪̭̳̬̝̻̱̜̦̬͙̯͔ͩ̏ͪͦ̈́͑ͩ̾͊͆̄ͭͫ́͘͜͢Ỵ͇͔̦͍̭̗̪̭̬̥̗̹̣͍̖̰̣͙̒͐ͭͦ̾́͢͞ ̵̖̳͓̪ͥͭ̊̉̅C̶͛͛ͤ̅͛̊ͦͣ̌͆ͩ̓̉͛͏̧͍͙̲͎̬̯̥̱͔̻̕͝Ọ̵̧̨̼͔̗̪̳̅̒͂̆ͫ̀̄ͫ̽̈́̈́ͧ̂ͪ̚ͅM̶̶̷̧̘͍̦̝̈̒͋̎͆́Ẻ̐̓̽̽͏͠҉̩͈̣͚̰̭͚̱̮͓̣̯̪͍̠̠͠",
		"HIVEMIND",
		"HIVEMIND",
		"HiVEmIND",
		"HIVEMIND",
		"HIVEMIND",
		"hivemind",
		"HIVEMIND",
		"HIVEMIND",
		"HIVEMIND",
		"HIVEMIND",
		"hivemind",
		"HIVEMIND",
		"HIVEmind",
		"Hivemind",
		"hiveMIND",
			};
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (timer > Random.Range(0.2f, 0.3f)) {
			GetComponent<Text>().text = zalgos[Random.Range(0, zalgos.Length)];

			timer = 0.0f;
		}
		if (timer%2 == 0) {
			GetComponent<Text> ().color = Random.ColorHSV ();
		}
	}
}
