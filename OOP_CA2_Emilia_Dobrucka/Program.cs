using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace OOP_CA2_Emilia_Dobrucka
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //Descripions
            //First Room
            Description FirstDescription = new Description()
            {
                Beginning = "Welcome to 'Live Or Die, Make Your Choice' - An Interactive Text Horror Game\nWarning this game have graphic scenarios, and moral choices that may be upsetting to some players.\n\nProceed only if you are prepared to face the consequences of your decisions.\nPress any key to start the game...",

                //Right path of the game
                StartGame = "Date: Monday, 10:52, 2005\n\nLoactan: Unknown\n\nYou wake up in total darkness. The air is thick, it taste like dust and decay. " +
                "Your body feels heavy, slow and limited when you try to move.\nYour head pounding and your memory is a blank void. Above you, a flickering lightbulb sputters to life, illuminating the space with a sickning yellow hue. " +
                "\nThe wall's tiles are cracked, rusted and dried out spots.\n\nThen you see it\nA tiny red tricycle stand in the middle of the space. There is a cracked porcelain doll on it, lifeless." +
                "\nIts glass eyes are focused on you and shine in the low light. It not grinning, too big, too human.\nIt holds a dusy walkman in its small hand. PLAY ME is written in shaky black letter across the walkman. \nA huge steel door stands behind the doll, bolted shut.",

                PlayWalkman = "\nYour hands shaking as you reach for the walkman. The doll's head tilts slightly as if observing you," +
                "\n and its plastic fingers creak as you pull the walkman free." +
                "\nYou press the play button, and static crackles through the tiny speaker. Then, a distorted voice begins to speak.",

                SearchDollsPockets = "You carefully examine the cracked porcelain doll, its glass eyes seeming to follow your every move. " +
                "\nYou reach into its tiny pockets, feeling around for anything that might be hidden inside. \nAfter a few moments of searching, your fingers brush against something small and paper like. \nYou pull it out to reveal a old looking piace of paper. " +
                "\nUnfolding the paper, you see that it's a note with a riddle written on it:",

                RigtAnswerPart1 = "\n\nAs you speak the words 'Jigsaw's game,' a low rumble echoes through the room. \nThe steel door behind the doll slowly creaks open, revealing a dimly lit corridor beyond." +
                "\nYou step through the doorway, leaving the oppressive room behind you. \nThe air in the corridor feels slightly less heavy, and you can't help but feel a glimmer of hope.",

                //Wrong path of the game

                SteelDoorFrist = "\n\nYou walk toward the steel door and as you walk past the cracked porcelain doll, you swear that you can feel these glass eyes wacth your everymove" +
                "\nThe cold surface of the door sending shiver down your spine, \nYou try to push it open, but it don't budge. It's locked tight, with no visible handle or keyhole." +
                "\nFrustrated, you step back and look around the room for any other possible exits or clues. \nThe flickering lightbulb above casts eerie shadows on the cracked tiles, making the room feel even more claustrophobic." +
                "\n\nYour focus returns to the porcelain doll with cracks after a few minutes. Every part of you freezes as soon as you see it, and you stagger back in disbelief.\n\nThe head of the doll has moved." +
                "\nWith those glassy, dull eyes, it's entirely turned around and starring at you.\nwhile its body, twisted in a way that shouldn't be possible, continues to face the opposite direction." +
                "\n\nYou catch a chilly breath in your throat. Your stomach tightens.\nYou can only stare back at it, motionless, for a little period.\n\nYou forcefully swallow, attempting to stifle the panic that is rising in your chest." +
                "\nThe doll's lifeless eyes are fixed on yours as you push yourself to approach it slowly and erratically, each step resonating in the still room.",

                FirstDeath = "The room is silent when you finish answering.\n\nNo gears turning.\n\nNo moving walls.\n\nNothing\n\nYou genuinely begin to think you've got it right for a little moment." +
                "As you look around the room, everything appears to be the same. After then, the lights flicker once, twice, and then become a sickly faint.\n\nA metal grate in the ceiling hisses open before you can respond." +
                "A chilly mist starts to descend. It feels like a little rain at first. Nearly harmless.\n\nThe burning then begins. There are thousands of tiny pinpricks all over your skin, each getting deeper, hotter, and sharper." +
                "\n\nYour skin sticks to your fingertips like melted wax when you clean your arms out of habit. The fog gets thicker.Your forearms split and blister. Long red threads of liquefied muscle start to trickle down your wrists." +
                "\n\nAs more acid pours down, the room responds with another hiss as your screams reverberate off the walls. Your lips dissolve into a moist, red mess as your face begins to run.\n\nYour vision is cloudy, bubbling, and then \n\nDarkness.",
            };

            //Second Room
            Description SecondDescription = new Description()
            {
                //Right path of the gmae  
                RigtAnswerPart2 = "The next room was nearly the same as the previous one, cold, quiet and terribly empty, but this time an old, rust-stained bed in the middle.\nAnother worn-out walkman with the words PLAY ME written in shaky handwriting on a strip of peeling tape across the front was lying on the mattress." +
                "\nAnother steel door stood behind the bed, Waiting, watching.",

                BedAndPlayIt = "\n\nYour footsteps echo through the empty room as you approach the bed. As you bend down and pick up the worn-out, dusty walkman, the stained matteress sages.\nYour thumb clicks the play button. Static hisses, followed by the return of the same distorted voice, this time closer and colder than before.",

                MoveBed = "The bed's rusty frame screeches across the floor as you push it aside. A large pit appears beneath it, filled to overflowing with the same needles" +
                "\nyou used to provide to the helpless people who depended on you.\nYour past is looking back at you from the shadows." +
                "\n\nA shiver runs up your spine as you stare down at the mass of needles. The fact that the voice is not offering you an option at all dawns on you at that very moment" +
                "\nIt want you to go down there and navigate the repercussions that you previously caused and ignored.",

                JumpInThePit = "With all your instincts telling you to stop, you take a long, trembling breath and lower yourself into the pit." +
                "\nA flood of discomfort rushes throught you the instant your weight moves into the darkness, cold metal, cramped pressure," +
                "the grind of your own decisions pressing in. However, you push over your anxitey and keep going because you have to find the codes or" +
                "both the door and your time will be lost forever." +
                "\n\nYour body huts with every step you take as you push yourself ahead, inch by inch. In the oppressive quiet," +
                "the sound of metal brushing against your flesh is painful. \nAs the darkness closes in on you, time seems to stretch, seconds seem like minutes, minutes like hours." +
                "\nFinally, something draws your attention. Something like a signal buried in the chaos, a small gleam flickering in the low light." +
                "\n\nYou reach out and grab the object, pulling it free from the needles. \nIt's a small metal box, and as you open it, you find one part of code you need to unlock the steel door " +
                "\nWith the first piece of the puzzle in hand, you keep to look for the other part of the code in this messy" +
                "\nYou find the five paice of the code.",

                LeaveTheNeedls = "You decide to get out of the hole and make your way to the steel door.\nAs you crawl out of the hole, you feel a sense of relief wash over you." +
                "\nYou make your way to the steel door, your heart pounding with anticipation. \nAs you approach the door, you see a keypad next to it, with five empty slots for the code." +
                "\n\nYou take a deep breath and take out the five piece to look at what are the five number and fiught out the code. The numbers are 2, 9, 16, 11, 8, and 9.",

                LookCloserAtFivePiece = "You examine the five pieces slowly, one after another, the room sinking into silence. Four of them are ordinary. Meaningless. Until the last one" +
                "\n\nIn the lower corner, a thin carving scratches through the surface - deliberate, controlled, unmistakably intentional. " +
                "You lean in, your breath shaky, as the message reveals itself like a whisper carved in pain:" +
                "\n\nRemember the rainbow order. \n\nA clue... or a warning",

                GoBackToTheKeypad = "\n\nYou turn your attren back to the Keypad and with your hands shaking with nervosness",

                RightCode = "\n\nThe moment your finger leaves the final button, something shifts. The room fills with a heavy, metallic cluck, and then, after" +
                "years of silence, the slow grinding of gears begins. The steel door trembles... \n\nthen begins to crawl open, inch by painful inch, shrieking" +
                "like metal being ripped apart. Cold air floods in from the darkness beyond. You take one last look at the room behind you, the place that condemned" +
                "you, before stepping through the threshold, leaving its suffocating walls to seal themselves shut behind out.",

                SecondDeath = "The final number is punched in. There's a long, panting silence.\n\nThere are no beeps.\n\nNot a click.\n\nThe steel door remained motionless." +
                "\n\nPraying that you have the code correct, you take a step back.It drags for seconds.\n\nThen you hear it.\n\nA quiet whir of machinery." +
                "\n\nAs you wait for a lock to release, you bend forward and place your ear against the cold steel door. However, the door isn't the source of the noise.It originates from below you." +
                "\n\nBefore you are able to move............\n\nThe floor breaks apart.\n\nYou fall waist-deep into a pit filled with thousands of ancient, rusted needles that pierce your skin from all sides, bending and cracking." +
                "Your scream just reverberates off the walls made of steel. \n\nThen, like a reverse bear trap, a cage slams down around your body with a loud metallic crack.\nYou are forced downward by it." +
                "\n\nAs the mechanism ratchets tighter and tighter, the needles tear through your muscles, grinding you into the pile until you are unable to move or breathe and can only feel the cold sting of metal and the crushing weight as everything goes dark."
            };

            //ThirdRoom
            Description ThirdDescription = new Description()
            {
                EnterTheThirdRoom = "You step into a long, dimly lit room. The door behind you slams shut with a metallic jolt, " +
                "the echo stretching out like a warning you were never meant to ignore. The air is coldr enough to string your lungs," +
                "and the single hanging bulb above you flickers in a frantic in a frantic, uneven rhuthm. In the center of the room sits a rusted metal table." +
                "Iron scales rest on top, heavy, industrial, it chains rattling softly as it sway on its own." +
                "The sound is faint but constant, like something just out of sight is breathing against them, keeping time with your heartbeat." +
                "Beside the scales lies a battered walkman. \n\nA strip of tape is pressed across its surface, wrinkled and stained with age." +
                "In jagged, uneven lettering, someone has written: PLAY ME. Your eyes drift past the table to the far wall, where another" +
                "steel door waits. It's different from the one that trapped you, cleaner, sturdier, almost inviting." +
                "Something in your gut insists that whatever lies behind it is important... \n\nthat it might be the key to your feedom. If you can earn it",

                PickTheWalkmanAandPresPlay = "You pick up the Walkman, your hand shaking so violently you nearly drop it." +
                "It feels heavier than the other two—not just in weight, but in presence, as if whatever waits inside it is pressing down on you." +
                "\n\nYou hesitate.\n\nYour breath stutters.\n\nWhat if the unfamiliar, unusually calm voice was lying?" +
                "\n\nWhat would happen if you were faced with more rooms, traps, and hard decisions?" +
                "\n\nWhat if, as a result of what you did to those lost souls, this is the conclusion you deserve?" +
                "\n\nAfter taking a deep breath, you feel thin and shaky. Pressing PLAY takes all of your remaining strength." +
                "\nStatic is all that's audible for a few seconds—soft, floating, smothering.\nThen the voice from nowhere comes back.",

                ExamineTheScalesMoreCloselyFirst = "Your footsteps echo through the chamber, slow, hollow impacts that ripple across the concrete like" +
                "distant thunder. The Scale, an ancient, rust-rotted building hanging by massive iron chains, becomes visible as you get near. " +
                "As if responding to your presence, the metal sways slightly and moans under its own weight. Five objects, each lying on" +
                " a tarnished metal plate, are set next to the scale.\n\nEvery item has a little tag made of cold steel underneath it. " +
                "The words are etched into the surface so forcefully that it resembles a collection of wounds rather than an engraving—deep, " +
                "furious gouges left by a hand that wants the message to pain." +
                "\n\nKNIFE: VIOLENCE \nA little folding knife with a discoloured and nicked blade. The handle appears to have been desperately " +
                "fixed because it is fractured and covered in torn black tape. The blade is half-open, stuck in midair, and like a quiet threat, it catches the flicker of the weak light." +
                "\n\nCOIN: GREED \nNumerous hands have worn the surface of a heavy gold coin. Even now, fingerprints dirty it, " +
                "as if people held onto it long after it was time to let go. There's a deep scratch in the middle of it, something deliberate, angry, and forceful." +
                "\n\nMASK: LIES \nA half-mask made of porcelain, similar to those used during masquerades. One smeared black line descends from the eyehole, " +
                "and the white surface is split along the cheek, giving the impression that the mask itself wept. Its smile is weak, frightening, and wholly untrue." +
                "\n\nLOCKET: LUST \nHeart-shaped locket with a damaged edge made of tarnished silver. It makes a slight metallic rattling when it moves, " +
                "indicating that something is within but the clasp is stuck shut. The metal seems almost unreasonably warm to the touch." +
                "\n\nSTONE: ANGER \nA black, jagged stone that could cut skin. It has been hurled violently, repeatedly, and with rage, as seen" +
                "by the chips and scratches on its surface. If someone is careless enough to grab it, the sharply glinting edges will cause them pain." +
                "\n\nEven though the items are perfectly silent, they all exude significance, recollection, and accusation.The deep, metallic creak of the Scale's " +
                "chains serves as a reminder that you have the power to make your own decisions and that the consequences of your transgressions are just around the corner." +
                "\n\nA metal plate under the center scale reads:\n“ANGER is the heaviest burden you carry.\nGREED is far heavier than it pretends to be." +
                "\nLIES weigh almost nothing—yet they cling like dust to the heart.\nVIOLENCE cuts deep, but even it cannot outweigh anger." +
                "\nAnd LUST… rests somewhere between desire and consequence.",

                IgnoreBothAndCheckTheSteelDoor = "The Walkman is silent and the rattling chains are left behind as you move away from the table." +
                "The air becomes dense, oppressive, and nearly viscous as you approach the steel door at the far end of the room. " +
                "Every stride turns into a battle, as if you're pushing past unseen barriers. It seems deliberate, " +
                "as though the room is attempting to keep you where you were supposed to be.",

                GoBackToTheTable = "With no other choice, you turn back to the table, its chilly metal surface acting as a silent judge, awaiting your choice.",

                RightScale = "You carefully and precisely position each sin on the scale. The metal moans from the shifting weight, and the chains creak." +
                "After that, there was silence.ideal harmony. Not even a millimetre of motion. \n\nNothing at all occurs for a little moment." +
                "\n\nThe silence seems to be engulfed by the chilly, empty room. \n\nAnd you start to feel doubt. \n\nWhat if you made the incorrect decision?" +
                "\n\nWhat if the solution was never found in the balance? \n\nWhat if you are left in a room with no way out, alone and forgotten, \n\nand this is where your life ends?" +
                "\n\nThen the walls reverberate with a deep, mechanical rumbling. Like a reluctant judge rendering a decision, the steel door starts to move, opening inch by excruciating inch." +
                "You don't think twice. As you dash over the threshold, you almost trip over your own feet. You stop. \n\nThe door is now completely open. However, what's beyond is not what you anticipated." +
                "No hallway. No way out. Not a single light. All that was seen was the enormous, silent, and incredibly empty darkness. \n\nYou move towards the emptiness because you have no other option." +
                "One step, followed by another... \n\nand you vanish into the shadows.",

                TobeContinud = "To be continued...",

                ThirdDeath = "You meticulously arrange every sin symbol on the rusty scale. The metal shakes and the chains moan. then becomes motionless.Nothing takes happen. Leaning forward, you consider whether to change the weights when" +
                "\n\nA wall panel opens with a snap. You are hit by a wave of stink that is strong, putrid, and clearly dead. Curiosity pulls you closer in the hopes of finding a way out, but you gag and cover your mouth." +
                "\n\nThen you hear it...... \n\nA wet, sluggish gurgling. In an instant, a burst of heated crimson liquid shoots out of the opening, smashing you with such force that it almost knocks you off your feet." +
                "\nYou're completely soaked, and the heavy liquid has blinded you.\n\nYou wipe your eyes and freeze. \n\nA slimy, bulging pig's head floats inches from your face, its dead eyes fixed on you. Your stomach \n\nIt's blood from pigs." +
                "And there will be more.\n\nThe floor gets flooded in a matter of seconds.\nHelpless, you scramble back, slipping and splashing. As the room fills, the pigs, whole carcasses, limbs, heads, slosh against you." +
                "\n\nYou see the table, your heart pounding.This is your one opportunity.The taste of rot and iron fills your tongue as you plunge through the surging blood, gagging. Pulling yourself up on it as quickly as you can" +
                "\n\nHowever, the blood continues to rise.\nHalfway through\nThree-quarters\nNow it's almost to the ceiling.\n\nYour cries for help are muted by the damp walls and the continuous churning of flesh and liquid." +
                "\nBeneath you, the table vanishes. With your head barely above the mixture of blood and lifeless pigs, you gasp as you swim through the thick crimson liquid.\n\nYour hands come into contact with the ceiling.\nNo more room." +
                "\nThere is no more air.\n\nYou inhale one final, pure breath that will be your last.\n\nAnd the chamber fills completely, engulfing you in the heavy blackness of pig blood.",
            };
            //Decisions
            //First Room
            Decision FirstDecision = new Decision()
            {
                FirstChoice = "\nOnly 1 will save you\nWhat do you do? \n1 Pick up the walkman and press play. \n2 Check the steel door\nYou: ",
                FirstChoiceRightW = "Pick up the walkman and press play",
                FirstChoiceRightN = "1",
                FirstChoiceWrongW = "Check the steel door",
                FirstChoiceWrongN = "2",

                SecChoice = "\nOnly 1 will save you\nWhat do you do? \n1 Search the doll's pockets. \n2 Ignore the doll and go to the steel door.\nYou: ",
                SecChoiceRightW = "Search the doll's pockets",
                SecChoiceRightN = "1",
                SecChoiceWrongW = "Ignore the doll and go to the steel door",
                SecChoiceWrongN = "2"
            };

            //Second Room
            Decision SecondDecision = new Decision()
            {
                ThiredChoice = "\n\nOnly 1 will save you\nWhat do you do?\n1 Approach the bed and press play.\n2 Ingore the bed and go to the steel door.\nYou: ",
                ThiredChoiceRightW = "Approach the bed and press play",
                ThiredChoiceRightN = "1",
                ThiredChoiceWrongW = "Ingore the bed and go to the steel door",
                ThiredChoiceWrongN = "2",

                FourChoice = "\nOnly 1 will save you\nWhat do you do? \n1 Look beneath the bed. \n2 Move toward the steel door. \nYou: ",
                FourChoiceRigthW = "Look beneath the bed",
                FourChoiceRigtN = "1",
                FourChoiceWrongW = "Move toward the steel door",
                FourChoiceWrongN = "2",

                FiveChoice = "\nOnly 1 will save you\nWhat do you do? \n1 Jump in the pit. \n2 Move toward the steel door. \nYou: ",
                FiveChoiceRigthW = " Jump in the pit.",
                FiveChoiceRigtN = "1",
                FiveChoiceWrongW = "Move toward the steel door.",
                FiveChoiceWrongN = "2",

                SixChoice = "\nOnly 2 will save you\nWhat do you do? \n1 Go through the needles again \n2 Get out and go to the steel door \nYou: ",
                SixChoiceWrongW = "Go through the needls again",
                SixChoiceWrongN = "1",
                SixChoiceRightW = "Get out and go to the steel door",
                SixChoiceRightN = "2",

                SevenChoice = "\nOnly 1 will save you\nWhat do you do? \n1 Look at the five pieces more closely. \n2 Enter the code. \nYou: ",
                SevenChoiceRightW = "Look at the five pieces more closely",
                SevenChoiceRightN = "1",
                SevenChoiceWrongW = "Enter the code",
                SevenChoiceWrongN = "2",

            };

            Decision ThirdDecision = new Decision()
            {
                EightChoice = "\nOnly 1 will save you\nWhat do you do?\n1 Pick the walkman and press play\n2 Examine the scales more closely first\n3 Ignore both and check the steel door \nYou: ",
                EightChoiceRightW = "Pick the walkman and press play",
                EightChoiceRightN = "1",
                EightChoiceFWrongW = "Examine the scales more closely first",
                EightChoiceFWrongN = "2",
                EightChoiceSWrongW = "Ignore both and check the steel door",
                EightChoiceSWrongN = "3",

                NineChoice = "\nOnly 1 will save you\nWhat do you do?\n 1 Pick the walkman and press play \n2 Ignore the walkman and check the steel door \nYou:",
                NineChoiceRightW = "Pick the walkman and press it",
                NineChoiceRightN = "1",
                NineChoiceWrongW = "Ignore the walkman and check the steel door",
                NineChoiceWrong = "2",

                TenChoice = "\nWhat do you do?\n1 Pick the walkman and press play\n2 Examine the scales more closely first \nYou: ",
                TenChoiceRightW = "Pick the walkman and press play",
                TenChoiceRightN = "1",
                TenChoiceFWrongW = "Examine the scales more closely first",
                TenChoiceFWrongN = "2",

                ElevenChoice = "\nOnly 1 will save you\nWhat do you do?\n1 Step toward the scale and face the weight of your sins\n2 Turn your back on the scale and approach the steel door \nYou: ",
                ElevenChoiceRightW = "Step toward the scale and face the weight of your sins",
                ElevenChoiceRightN = "1",
                ElevenChoiceWrongW = "Turn your back on the scale and approach the steel door",
                ElevenChoiceWrongN = "2",
            };
            ////VoiceTalkings
            VoiceTalking vioceTalking = new VoiceTalking()
            {
                FirstTime = "Unknown Voice:\nHello.. Old Friend, You don't know me... but I've been watching you. I am aware of how your days are laid out,\nhow heavy your hands are, and the list of favors and debts you refer to as 'Business'.\nSelling hope, fragile dreams to the desperate was the foundation of your life.\nA solution, an escape route, a future that never came. You saw them rise on your falsehoods. And collapse underneath them. Finding out the actual cost of what you sold is now necessary." +
             "\n\nI want to play a game\nIt's the same game you taught them, exchanging hope for something more lasting. The currency is truth, and the stakes are only more equitable tonight.\nI will give you hope. Three rooms is a straightforward deal. Three puzzles. One escape route." +
             "\nYou have 30 seconds in each room to figure out what's within. If you don't complete the puzzle before the clock runs out, your life will end here and the light won't come back.\n\nTo begin, I shall be merciful.\nThe doll that is keeping on you has a mystery concealed in its pockets. Thiry second are all you have to locate it and provide the right answer. If you fail, the repercussions are final." +
             "\n\nThe instant this recording concludes, your timer starts.\nTick-tock \nTick-tock, your life timer is ticking",

                SecondTime = "Unknown Voice:\nGreeting again, old friend. You have arrived in the second room. But realise that what is coming up is not just another puzzle." +
             "This is a personal trial. It touches on part of your life that you would perfer to forget. The decisions you swore to never catch up to you and the regrets you buried." +
             "\n\nAnd yet here they are, just waiting. When the past finally demands its due, let's see how far you will go." +
             "\nThe countdown on the door in front of you has already begun when you enter this area. When the timer reaches zero, the way forward is sealed in stone." +
             "\n\nAlong with it, the life you have been holding onto. You are getting closer to an unchangeable fate with every second you waste." +
             "\nYou need to collect five slips of paper, each with a necessary number, in order to unlock the door ahead. However, they will not be given to you." +
             "\nStep by step and inch by inch, you will have to endure the same neglect and dirt that your clients once endured." +
             "\nThen and only then can you comprehend the suffering you caused them. Let me give you a hint. But don't see that as a sign of kindness." +
             "\n\nA straightforward search is not what awaiting you. Imagine it like trying to find a needle hidden deep in a rotting haystack." +
             "\nKeep in mind that the parts need to be put in the rainbow's order. If you don't get it, you won't succed in anytinhing else.",

                ThirdTime = "Unknown: \nWell, well… you’ve managed to surprise me. I truly doubted you’d survive the first room, " +
             "in fact, I nearly chose not to create this third one at all. But here we are. And now… you stand one step away from whatever freedom you believe you deserve." +
             "In this room, you will confront your sins. Every one of them. \n\nThe very sins that dimmed the light of those who crossed your path.So listen carefully." +
             "Sins do not weigh what you think they do.You look at objects and see only mass and matter… but the soul measures truth differently." +
             "Before you are three scales.Your task is simple:balance them with the weight of your sins.But appearances deceive." +
             "\n\nANGER is the heaviest burden you carry." +
             "\n\nGREED is far heavier than it pretends to be." +
             "\n\nLIES weigh almost nothing yet they cling like dust to the heart." +
             "\n\nVIOLENCE cuts deep, but even it cannot outweigh anger." +
             "\n\nAnd LUST… rests somewhere between desire and consequence." +
             "\n\nChoose wisely. Here, every miscalculation carries a price."
            };

            //Puzzle
            Puzzle riddle = new Puzzle() { Question = "\n\n'I speak without words, \nI judge without law, \nYour choices are keys, \nBut the wrong one will gnaw. \nI offer you freedom, \nYet bind you in fear, \nWhat am I? \n\nWhat is your answer?", Answer = "Jigsaw's game"};
            Puzzle Code = new Puzzle() { Question = " \nYou Enter:", Answer = "2911689"};
            Puzzle TheWeightOfSins = new Puzzle() { LeftScale = "\nWhat do you put on left side?", LeftAnswerF = "Coin, Locket", LeftAnswerS = "COIN, LOCKET", RightScale = "What do you put on the right side?", RightAnswerF = "KNIFE, STONE", RightAnswerS = "Knife, Stone" };


            //Rooms
            Room Firstroom = new Room() { FirstDescription = FirstDescription, FirstDecision = FirstDecision, Voices = vioceTalking, RoomPuzzle = riddle, };
            Room Secondroom = new Room { SecondDescription = SecondDescription, SecondDecision = SecondDecision, Voices = vioceTalking, RoomPuzzle = Code, };
            Room Thirdroom = new Room { ThirdDescription = ThirdDescription, ThirdDecision = ThirdDecision, Voices = vioceTalking, RoomPuzzle = TheWeightOfSins };
            //Puzzle p2 = new Puzzle() { Question = "What is 1 plus 1", Answer = "2" };
            //Room room2 = new Room() { Name = "Library", RoomPuzzle = p1 };

            //Console.WriteLine($"You are in the {room.Name}, please answer this question {room.RoomPuzzle.Question}");
            //string answer = Console.ReadLine();
            //if (answer == room.RoomPuzzle.Answer)
            //{
            //    Console.WriteLine("You win - go to room 2");
            //}

            StoryTalks(Firstroom.FirstDescription.Beginning);
            Console.ReadKey();
            await ClearScreen();
            StoryTalks(Firstroom.FirstDescription.StartGame);
            Console.WriteLine("\n");
            CuntdownTimer timer1 = new CuntdownTimer(30);
            timer1.Start();
            StoryTalks(Firstroom.FirstDecision.FirstChoice);
            string FirstChoice = Console.ReadLine();
            timer1.Stop();
            if (FirstChoice == Firstroom.FirstDecision.FirstChoiceRightW || FirstChoice == Firstroom.FirstDecision.FirstChoiceRightN)
            {

                StoryTalks(Firstroom.FirstDescription.PlayWalkman);
                await ClearScreen();
                VoiceTalks(Firstroom.Voices.FirstTime);
                Console.WriteLine("\n");
                CuntdownTimer timer2 = new CuntdownTimer(30);
                timer2.Start();
                StoryTalks(Firstroom.FirstDecision.SecChoice);
                string SecChoice = Console.ReadLine();
                timer2.Stop();
                if (SecChoice == Firstroom.FirstDecision.SecChoiceRightW || SecChoice == Firstroom.FirstDecision.SecChoiceRightN)
                {
                    await ClearScreen();
                    StoryTalks(Firstroom.FirstDescription.SearchDollsPockets);
                    CuntdownTimer timer3 = new CuntdownTimer(30);
                    timer3.Start();
                    StoryTalks(Firstroom.RoomPuzzle.Question);
                    timer3.Start();
                    string FirstAns = Console.ReadLine();
                    timer3.Stop();
              
                    if (FirstAns == Firstroom.RoomPuzzle.Answer)
                    {
                        StoryTalks(Firstroom.FirstDescription.RigtAnswerPart1);
                        await ClearScreen();
                        StoryTalks(Secondroom.SecondDescription.RigtAnswerPart2);
                        CuntdownTimer timer4 = new CuntdownTimer(30);
                        timer4.Start();
                        StoryTalks(Secondroom.SecondDecision.ThiredChoice);
                        string ThiredChoice = Console.ReadLine();
                        timer4.Stop();
                        if (ThiredChoice == Secondroom.SecondDecision.ThiredChoiceRightW || ThiredChoice == Secondroom.SecondDecision.ThiredChoiceRightN)
                        {
                            StoryTalks(Secondroom.SecondDescription.BedAndPlayIt);
                            await ClearScreen();
                            VoiceTalks(Secondroom.Voices.SecondTime);
                            CuntdownTimer timer5 = new CuntdownTimer(30);
                            timer5.Start();
                            StoryTalks(Secondroom.SecondDecision.FourChoice);
                            string FourChoice = Console.ReadLine();
                            timer5.Stop();
                            if (FourChoice == Secondroom.SecondDecision.FourChoiceRigthW || FourChoice == Secondroom.SecondDecision.FourChoiceRigtN)
                            {
                                await ClearScreen();
                                StoryTalks(Secondroom.SecondDescription.MoveBed);
                                CuntdownTimer timer6 = new CuntdownTimer(30);
                                timer6.Start();
                                StoryTalks(Secondroom.SecondDecision.FiveChoice);
                                string FiveChoice = Console.ReadLine();
                                timer6.Stop();
                                if (FiveChoice == Secondroom.SecondDecision.FiveChoiceRigthW || FiveChoice == Secondroom.SecondDecision.FiveChoiceRigtN)
                                {
                                    await ClearScreen();
                                    StoryTalks(Secondroom.SecondDescription.JumpInThePit);
                                    CuntdownTimer timer7 = new CuntdownTimer(30);
                                    timer7.Start();
                                    StoryTalks(Secondroom.SecondDecision.SixChoice);
                                    string SixChoice = Console.ReadLine();
                                    timer7.Stop();

                                    if (SixChoice == Secondroom.SecondDecision.SixChoiceWrongW || SixChoice == Secondroom.SecondDecision.SixChoiceWrongN)
                                    {

                                    }
                                    else if (SixChoice == Secondroom.SecondDecision.SixChoiceRightW || SixChoice == Secondroom.SecondDecision.SixChoiceRightN)
                                    {
                                        await ClearScreen();
                                        StoryTalks(Secondroom.SecondDescription.LeaveTheNeedls);
                                        CuntdownTimer timer8 = new CuntdownTimer(30);
                                        timer8.Start();
                                        StoryTalks(Secondroom.SecondDecision.SevenChoice);
                                        string SevenChoice = Console.ReadLine();
                                        timer8.Stop();
                                        if (SevenChoice == Secondroom.SecondDecision.SevenChoiceRightW || SevenChoice == Secondroom.SecondDecision.SevenChoiceRightN)
                                        {
                                            await ClearScreen();
                                            StoryTalks(Secondroom.SecondDescription.LookCloserAtFivePiece);
                                            StoryTalks(Secondroom.SecondDescription.GoBackToTheKeypad);
                                            CuntdownTimer timer9 = new CuntdownTimer(30);
                                            timer9.Start();
                                            StoryTalks(Secondroom.RoomPuzzle.Question);
                                            string SecAns = Console.ReadLine();
                                            timer9.Stop();
                                            if (SecAns == Secondroom.RoomPuzzle.Answer)
                                            {
                                                StoryTalks(Secondroom.SecondDescription.RightCode);
                                                await ClearScreen();
                                                StoryTalks(Thirdroom.ThirdDescription.EnterTheThirdRoom);
                                                CuntdownTimer timer10 = new CuntdownTimer(30);
                                                timer10.Start();
                                                StoryTalks(Thirdroom.ThirdDecision.EightChoice);
                                                string EightChoice = Console.ReadLine();
                                                timer10.Stop();
                                                if (EightChoice == Thirdroom.ThirdDecision.EightChoiceRightW || EightChoice == Thirdroom.ThirdDecision.EightChoiceRightN)
                                                {
                                                    StoryTalks(Thirdroom.ThirdDescription.PickTheWalkmanAandPresPlay);
                                                    await ClearScreen();
                                                    VoiceTalks(Thirdroom.Voices.ThirdTime);
                                                    CuntdownTimer timer11 = new CuntdownTimer(30);
                                                    timer11.Start();
                                                    StoryTalks(Thirdroom.ThirdDecision.ElevenChoice);
                                                    string ElevenChoice = Console.ReadLine();
                                                    timer11.Stop();
                                                    if (ElevenChoice == Thirdroom.ThirdDecision.ElevenChoiceRightW || ElevenChoice == Thirdroom.ThirdDecision.ElevenChoiceRightN)
                                                    {
                                                        await ClearScreen();
                                                        StoryTalks(Thirdroom.ThirdDescription.ExamineTheScalesMoreCloselyFirst);
                                                        CuntdownTimer timer12 = new CuntdownTimer(30);
                                                        timer12.Start();
                                                        StoryTalks(Thirdroom.RoomPuzzle.LeftScale);
                                                        string LeftAns = Console.ReadLine();
                                                        timer12.Stop();
                                                        await ClearScreen();    
                                                        CuntdownTimer timer13 = new CuntdownTimer(30);
                                                        timer13.Start();
                                                        StoryTalks(Thirdroom.RoomPuzzle.RightScale);
                                                        string RightAns = Console.ReadLine();
                                                        timer13.Stop();
                                                        if ((LeftAns == Thirdroom.RoomPuzzle.LeftAnswerF || LeftAns == Thirdroom.RoomPuzzle.LeftAnswerS) && (RightAns == Thirdroom.RoomPuzzle.RightAnswerF || RightAns == Thirdroom.RoomPuzzle.RightAnswerS))
                                                        {
                                                            await ClearScreen();
                                                            StoryTalks(Thirdroom.ThirdDescription.RightScale);
                                                            await ClearScreen();
                                                            StoryTalks(Thirdroom.ThirdDescription.TobeContinud);
                                                        }
                                                        else
                                                        {
                                                            await ClearScreen();
                                                            StoryTalks(Thirdroom.ThirdDescription.ThirdDeath);
                                                        }

                                                    }
                                                    else if (ElevenChoice == Thirdroom.ThirdDecision.ElevenChoiceWrongW || ElevenChoice == Thirdroom.ThirdDecision.ElevenChoiceWrongN)
                                                    {

                                                    }
                                                }
                                                else if (EightChoice == Thirdroom.ThirdDecision.EightChoiceFWrongW || EightChoice == Thirdroom.ThirdDecision.TenChoiceFWrongW)
                                                {
                                                    await ClearScreen();
                                                    StoryTalks(Thirdroom.ThirdDescription.ExamineTheScalesMoreCloselyFirst);
                                                }
                                                else if (EightChoice == Thirdroom.ThirdDecision.EightChoiceSWrongW || EightChoice == Thirdroom.ThirdDecision.EightChoiceSWrongN)
                                                {
                                                    //await ClearScreen();
                                                    //StoryTalks(Thirdroom.ThirdDescription.IgnoreBothAndCheckTheSteelDoor);
                                                    //StoryTalks(Thirdroom.ThirdDescription.GoBackToTheTable);
                                                    //StoryTalks(Thirdroom.ThirdDecision.TenChoice);
                                                    //string TenChoice = Console.ReadLine();
                                                    //if (TenChoice == Thirdroom.ThirdDecision.ThiredChoiceRightW || TenChoice == Thirdroom.ThirdDecision.ThiredChoiceRightN)
                                                    //{

                                                    //}
                                                    //else if (TenChoice == Thirdroom.ThirdDecision.ThiredChoiceWrongW || TenChoice == Thirdroom.ThirdDecision.TenChoiceFWrongN)
                                                    //{

                                                    //}
                                                }
                                                else
                                                {

                                                }
                                            }
                                            else
                                            {
                                                await ClearScreen();
                                                StoryTalks(Secondroom.SecondDescription.SecondDeath);
                                            }
                                        }

                                    }
                                    else if (FiveChoice == Secondroom.SecondDecision.FiveChoiceWrongW || FiveChoice == Secondroom.SecondDecision.FiveChoiceWrongN)
                                    {

                                    }


                                }
                                else if (FourChoice == Secondroom.SecondDecision.FourChoiceWrongW || FourChoice == Secondroom.SecondDecision.FourChoiceWrongN)
                                {

                                }


                            }
                            else if (ThiredChoice == Secondroom.SecondDecision.ThiredChoiceWrongW || ThiredChoice == Secondroom.SecondDecision.ThiredChoiceWrongN)
                            {

                            }

                        }
                        
                    }
                    else
                    {
                        await ClearScreen();
                        StoryTalks(Firstroom.FirstDescription.FirstDeath);
                    }

                }
                else if (FirstChoice == Firstroom.FirstDecision.FirstChoiceWrongW || FirstChoice == Firstroom.FirstDecision.FirstChoiceWrongN)
                {
                    await ClearScreen();
                    StoryTalks(Firstroom.FirstDescription.SteelDoorFrist);
                    await ClearScreen();
                    StoryTalks(Firstroom.FirstDescription.PlayWalkman);
                }
            }
        }         
     
        //Methods

        //Clears the screen with a .... Animation
        public static async Task ClearScreen()
        {
            StoryTalks(".....");
            await Task.Delay(200);
            StoryTalks("....");
            await Task.Delay(200);
            StoryTalks("...");
            await Task.Delay(200);
            StoryTalks("..");
            await Task.Delay(200);
            StoryTalks(".");
            await Task.Delay(200);
            Console.Clear();
        }

        //Print the story text letter by letter 
        public static void StoryTalks(string textStory, int delay = 60)
        {
            //Make sure that the text is prints below the timer
            if (Console.CursorTop < 2)
            { Console.SetCursorPosition(0, 2); }

            //Does Nothing if the textStory is empty
            if (textStory == null)
            {
                return;
            }
            //Print out each of the letter with delay which is 60
            foreach (char a in textStory)
            {
                Console.Write(a);
                //Pasue for 60
                Thread.Sleep(delay);
            }
            //Go to the next line
            Console.WriteLine();
        }

        //Print the text letter by letter 

        public static void VoiceTalks(string text, int delay = 70)
        {


            //Make sure that the text is prints below the timer
            if (Console.CursorTop < 2)
            {
                Console.SetCursorPosition(0, 2);

            }

            //Does Nothing if the textStory is empty
            if (text == null)
                return;

            //Print out each of the letter with delay which is 60
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            //Go to the next line
            Console.WriteLine();
        }          
    }
}
