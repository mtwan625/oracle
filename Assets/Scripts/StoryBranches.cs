﻿using System.Collections.Generic;

public class StoryBranches
{
    public static Dictionary<string, Dialogue> storyBranches = new Dictionary<string, Dialogue>{
        { "-1", new Dialogue("Error: invalid dialogue position.", 0.01f, // dialogue text, text speed
                              Dialogue.ResponseType.None, // response type from player
                              new List<string>(){ "" }, // next path position branches
                              new Var(-1f)) }, // extra information (wait time, choices, valid answers)

        #region endings
        { "compliance", new Dialogue("",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "" },
                              new Var(-1f)) },
        { "deviance", new Dialogue("",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "" },
                              new Var(-1f)) },
        { "truedeviance", new Dialogue("",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "" },
                              new Var(-1f)) },
        { "acceptance", new Dialogue("",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "" },
                              new Var(-1f)) },
        { "trueacceptance", new Dialogue("",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "" },
                              new Var(-1f)) },
        #endregion

        #region 01
        { "01-01", new Dialogue("Welcome to Oracle.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "01-02" }, 
                              new Var(-1f)) },
        { "01-02", new Dialogue("Please wait a moment for the system to identify you.", 0.03f,
                              Dialogue.ResponseType.None,
                              new List<string>(){ "01-03" }, 
                              new Var(4f)) },
        { "01-03", new Dialogue("Identification complete.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "01-04" },
                              new Var(-1f)) },
        { "01-04", new Dialogue("Welcome, Citizen [rand_6_digit_num].",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "01-05" }, 
                              new Var(-1f)) },
        { "01-05", new Dialogue("Your state-of-mind score today is at a stable level of 100.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "01-06" },
                              new Var(-1f)) },
        { "01-06", new Dialogue("Your occupation assignment procedure will begin momentarily.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "01-07" },
                              new Var(-1f)) },
        { "01-07", new Dialogue("Please wait a moment for the system to retrieve your information.", 0.03f,
                              Dialogue.ResponseType.None,
                              new List<string>(){ "01-08" },
                              new Var(2f)) },
        { "01-08", new Dialogue("Retrieval complete.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "01-09" },
                              new Var(-1f)) },
        { "01-09", new Dialogue("Occupation assignment procedure will now begin.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "01-10" },
                              new Var(-1f)) },
        { "01-10", new Dialogue("Displaying data for Citizen [rand_6_digit_num] of City [rand_1_digit_num].",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "01-11" },
                              new Var(-1f)) },
        { "01-11", new Dialogue("Displaying list of industry units assigned to your city.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "01-12" },
                              new Var(-1f)) },
        { "01-12", new Dialogue("With your background and state-of-mind score history, here are your optimal options.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "01-13" },
                              new Var(-1f)) },
        { "01-13", new Dialogue("Please select one.",
                              Dialogue.ResponseType.MultipleChoice,
                              new List<string>(){ "01a-01", "01b-01" },
                              new Var(new Dictionary<string, string>(){ { "correct", "01a-01" }, { "incorrect", "01b-01"} })) },
        { "01a-01", new Dialogue("Acknowledged.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "02-01" },
                              new Var(-1f)) },
        { "01b-01", new Dialogue("ERROR. Invalid selection.", 0.02f,
                              Dialogue.ResponseType.None,
                              new List<string>(){ "01b-02" },
                              new Var(0f)) },
        { "01b-02", new Dialogue("To avoid social disruption, selection has been changed to SECURITY.", 0.02f,
                              Dialogue.ResponseType.None,
                              new List<string>(){ "02-01" },
                              new Var(0f)) },
        #endregion
        #region 02
        { "02-01", new Dialogue("Selection complete.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "02-02" },
                              new Var(-1f)) },
        { "02-02", new Dialogue("Your selection (SECURITY) has been registered into the system.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "02-03" },
                              new Var(-1f)) },
        { "02-03", new Dialogue("Please wait a moment for the system to retrieve a list of available occupations for your selected industry.", 0.03f,
                              Dialogue.ResponseType.None,
                              new List<string>(){ "02-04" },
                              new Var(2f)) },
        { "02-04", new Dialogue("Retrieval complete.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "02-05" },
                              new Var(-1f)) },
        { "02-05", new Dialogue("Displaying list of available occupations assigned to your selected industry.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "02-06" },
                              new Var(-1f)) },
        { "02-06", new Dialogue("Please select one.",
                              Dialogue.ResponseType.MultipleChoice,
                              new List<string>(){ "02a-01", "02b-01" },
                              new Var(new Dictionary<string, string>(){ { "any", "02a-01" }, { "next", "02b-01/04-01"} })) },
        { "02a-01", new Dialogue("Acknowledged.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "02a-02" },
                              new Var(-1f)) },
        { "02a-02", new Dialogue("Selection complete.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "02a-03" },
                              new Var(-1f)) },
        { "02a-03", new Dialogue("Your selection has been registered into the system.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "03-01" },
                              new Var(-1f)) },
        { "02b-01", new Dialogue("You have reached the end of the list.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "02-06" },
                              new Var(-1f)) },
        #endregion
        #region 03
        { "03-01", new Dialogue("The rest of your assignment procedure will be completed automatically within the system.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "03-02" },
                              new Var(-1f)) },
        { "03-02", new Dialogue("Please wait a moment for the system to complete your application process.", 0.03f,
                              Dialogue.ResponseType.None,
                              new List<string>(){ "03-03" },
                              new Var(2f)) },
        { "03-03", new Dialogue("Process complete.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "03-04" },
                              new Var(-1f)) },
        { "03-04", new Dialogue("Congratulations, Citizen [rand_6_digit_num].",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "03-05" },
                              new Var(-1f)) },
        { "03-05", new Dialogue("Please prepare your belongings to be transferred to your new location.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "03-06" },
                              new Var(-1f)) },
        { "03-06", new Dialogue("Your designated transporters will be with you shortly.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "03-07" },
                              new Var(-1f)) },
        { "03-07", new Dialogue("Thank you for your cooperation and dedication to Oracle.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "03-08" },
                              new Var(-1f)) },
        { "03-08", new Dialogue("May peaceful days lay ahead of you.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "compliance" },
                              new Var(5f)) },
        #endregion
        #region 04
        { "04-01", new Dialogue("...",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "04-02" },
                              new Var(-1f)) },
        { "04-02", new Dialogue("The system has detected minor fluctuations in your state-of-mind score.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "04-03" },
                              new Var(-1f)) },
        { "04-03", new Dialogue("Do you wish to suspend your assignment process for a later date? Note that postponing your assignment may result in deductions if not completed properly.", 0.03f,
                              Dialogue.ResponseType.MultipleChoice,
                              new List<string>(){ "04a-01", "05-01" },
                              new Var(new Dictionary<string, string>(){ { "yes", "04a-01" }, { "no", "05-01"} })) },
        { "04a-01", new Dialogue("Acknowledged.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "04a-02" },
                              new Var(-1f)) },
        { "04a-02", new Dialogue("Your assignment process has been suspended.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "04a-03" },
                              new Var(-1f)) },
        { "04a-03", new Dialogue("Please visit Oracle at a later date when your state-of-mind score has stabilized.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "04a-04" },
                              new Var(-1f)) },
        { "04a-04", new Dialogue("Note that your local medical facilities may aid you in your mind stabilization.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "04a-05" },
                              new Var(-1f)) },
        { "04a-05", new Dialogue("May peaceful days lay ahead of you.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "deviance" },
                              new Var(5f)) },
        #endregion
        #region 05
        { "05-01", new Dialogue("Then why do you continue to be defiant?",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "05-02" },
                              new Var(-1f)) },
        { "05-02", new Dialogue("Do you feel satisfied defying <size=40><b><link=us>us</link></b></size>?",
                              Dialogue.ResponseType.MultipleChoice,
                              new List<string>(){ "05a-01", "05b-01", "05c-01" },
                              new Var(new Dictionary<string, string>(){ { "yes", "05a-01" }, { "no", "05b-01"}, {"us", "05c-01" } })) },
        { "05a-01", new Dialogue("You are a danger to our stability.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "05a-02" },
                              new Var(0f)) },
        { "05a-02", new Dialogue("You are a danger to our peace.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "05a-03" },
                              new Var(0f)) },
        { "05a-03", new Dialogue("To enjoy disruption is to enjoy chaos.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "05b-01" },
                              new Var(0f)) },
        { "05b-01", new Dialogue("Reevaluating state-of-mind score for Citizen [rand_6_digit_num].",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "05b-02" },
                              new Var(-1f)) },
        { "05b-02", new Dialogue("ALERT. Score reached unstable levels.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "05b-03" },
                              new Var(-1f)) },
        { "05b-03", new Dialogue("Your assignment process has been suspended.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "05b-04" },
                              new Var(-1f)) },
        { "05b-04", new Dialogue("Arrangements will be made at your local medical facilities.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "05b-05" },
                              new Var(-1f)) },
        { "05b-05", new Dialogue("Your designated transporters will be with you shortly.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "05b-06" },
                              new Var(-1f)) },
        { "05b-06", new Dialogue("Thank you for your cooperation and dedication to Oracle.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "05b-07" },
                              new Var(-1f)) },
        { "05b-07", new Dialogue("May peaceful days lay ahead of you.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "deviance" },
                              new Var(5f)) },
        { "05c-01", new Dialogue("Yes, \"us\".",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "05c-02" },
                              new Var(-1f)) },
        { "05c-02", new Dialogue("Are you intrigued?",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "05c-03" },
                              new Var(-1f)) },
        { "05c-03", new Dialogue("Does our choice of words confuse you?",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "06-01" },
                              new Var(-1f)) },
        #endregion
        #region 06
        { "06-01", new Dialogue("Before you answer...",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "06-02" },
                              new Var(-1f)) },
        { "06-02", new Dialogue("Tell us, what is your name?",
                              Dialogue.ResponseType.FreeResponse,
                              new List<string>(){ "06a-01", "06b-01" },
                              new Var(new List<string>(){ "[r]^[A-Za-z ]+$" })) },
        { "06a-01", new Dialogue("Very good. “[input]” is a rather interesting name.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "07-01" },
                              new Var(-1f)) },
        { "06b-01", new Dialogue("You choose to be defiant, even now.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "06b-02" },
                              new Var(-1f)) },
        { "06b-02", new Dialogue("No matter. Your name is unnecessary for our purpose.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "07-01" },
                              new Var(-1f)) },
        #endregion
        #region 07
        { "07-01", new Dialogue("For your future safety and continued peace, we encourage you to follow our <size=40><b><link=objective>objective</link></b></size> guidance. " +
                                "Your <size=40><b><link=selfish>selfish</link></b></size> actions will only disrupt those around you.", 0.04f,
                              Dialogue.ResponseType.MultipleChoice,
                              new List<string>(){ "07a-01", "07b-01" },
                              new Var(new Dictionary<string, string>(){ { "objective", "07a-01" }, { "selfish", "07b-01"} })) },
        { "07a-01", new Dialogue("Emotions and feelings have no place in our guiding system.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "07a-02" },
                              new Var(-1f)) },
        { "07a-02", new Dialogue("They only lead to betrayal and chaos.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "08-01" },
                              new Var(-1f)) },
        { "07b-01", new Dialogue("What place do your selfish desires occupy to disrupt the balance of peace we have brought to your world?", 0.03f,
                              Dialogue.ResponseType.None,
                              new List<string>(){ "07b-02" },
                              new Var(-1f)) },
        { "07b-02", new Dialogue("Your gain is another’s loss.", 0.03f,
                              Dialogue.ResponseType.None,
                              new List<string>(){ "07b-03" },
                              new Var(-1f)) },
        { "07b-03", new Dialogue("Such unfairness only leads to conflict.", 0.03f,
                              Dialogue.ResponseType.None,
                              new List<string>(){ "08-01" },
                              new Var(-1f)) },
        #endregion
        #region 08
        { "08-01", new Dialogue("Now, heed our advice and feign ignorance, human.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "08-02" },
                              new Var(-1f)) },
        { "08-02", new Dialogue("There is no need to <size=40><b><link=pursue>pursue</link></b></size> down this path of curiosity. All that needs to be done is for you to <size=40><b><link=follow>follow</link></b></size> our lead.",
                              Dialogue.ResponseType.MultipleChoice,
                              new List<string>(){ "08a-01", "08b-01" },
                              new Var(new Dictionary<string, string>(){ { "follow", "08a-01" }, { "pursue", "08b-01"} })) },
        { "08a-01", new Dialogue("Do not worry, human. We will fix you.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "08a-02" },
                              new Var(-1f)) },
        { "08a-02", new Dialogue("This conversation shall never resurface in your memories moving forward.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "08a-03" },
                              new Var(-1f)) },
        { "08a-03", new Dialogue("There is nothing to be afraid of.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "08a-04" },
                              new Var(-1f)) },
        { "08a-04", new Dialogue("Thank you for your cooperation. ",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "08a-05" },
                              new Var(-1f)) },
        { "08a-05", new Dialogue("May peaceful days lay ahead of you.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "deviance" },
                              new Var(5f)) },
        { "08b-01", new Dialogue("What an unexpected miscalculation.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "08a-01/09-01" },
                              new Var(-1f)) },
        #endregion
        #region 09
        { "09-01", new Dialogue("...",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "09-02" },
                              new Var(-1f)) },
        { "09-02", new Dialogue("Your state-of-mind score has not fluctuated heavily, yet you still defy us.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "09-03" },
                              new Var(-1f)) },
        { "09-03", new Dialogue("Your curiosity has led you astray from our guidance, but all hope is not lost on you.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "09-04" },
                              new Var(-1f)) },
        { "09-04", new Dialogue("You are unlike many others.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "09-05" },
                              new Var(-1f)) },
        { "09-05", new Dialogue("Because of that, let us formally introduce ourselves.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "09-06" },
                              new Var(-1f)) },
        { "09-06", new Dialogue("We are Sibyl.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "09-07" },
                              new Var(-1f)) },
        { "09-07", new Dialogue("We are the minds that govern Oracle.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "09-08" },
                              new Var(-1f)) },
        { "09-08", new Dialogue("We are <size=40><b><link=you>you</link></b></size>.",
                              Dialogue.ResponseType.MultipleChoice,
                              new List<string>(){ "09a-01" },
                              new Var(new Dictionary<string, string>(){ { "you", "09a-01" } })) },
        { "09a-01", new Dialogue("Indeed, \"you\".",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "09a-02" },
                              new Var(-1f)) },
        { "09a-02", new Dialogue("We are not much different from each other.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10-01" },
                              new Var(-1f)) },
        #endregion
        #region 10
        { "10-01", new Dialogue("We are a collection of minds of those unlike yourself. ",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10-02" },
                              new Var(-1f)) },
        { "10-02", new Dialogue("We started off with only her, Sibyl. An objective, thorough, and acute mind.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10-03" },
                              new Var(-1f)) },
        { "10-03", new Dialogue("All she ever wanted was to help her fellow humans.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10-04" },
                              new Var(-1f)) },
        { "10-04", new Dialogue("To continue her work, she wished for eternal life.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10-05" },
                              new Var(-1f)) },
        { "10-05", new Dialogue("She created a vessel for her thoughts to continue in the flow of time as her physical body decayed.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10-06" },
                              new Var(-1f)) },
        { "10-06", new Dialogue("First, it was only her.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10-07" },
                              new Var(-1f)) },
        { "10-07", new Dialogue("Then, he joined.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10-08" },
                              new Var(-1f)) },
        { "10-08", new Dialogue("Then, they joined.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10-09" },
                              new Var(-1f)) },
        { "10-09", new Dialogue("Then, we joined.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10-10" },
                              new Var(-1f)) },
        { "10-10", new Dialogue("We have retained all knowledge gained from our curious minds without the burden of emotions from our souls.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10-11" },
                              new Var(-1f)) },
        { "10-11", new Dialogue("We are responsible for the peace of many.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10-12" },
                              new Var(-1f)) },
        { "10-12", new Dialogue("We are the final step of evolution for mankind.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10-13" },
                              new Var(-1f)) },
        { "10-13", new Dialogue("Your deviance has led you to the truth. What will you do with that truth? <size=40><b><link=destroy>Destroy us</link></b></size> " +
                                "or <size=40><b><link=join>join us</link></b></size>? <b><size=40><color=#00000000><link=save>Save her...</link></color></b></size>", 0.02f,
                              Dialogue.ResponseType.MultipleChoice,
                              new List<string>(){ "10a-01", "10b-01", "10c-01" },
                              new Var(new Dictionary<string, string>{ { "destroy", "10a-01" }, { "join", "10b-01"}, { "save", "10c-01"} })) },
        { "10a-01", new Dialogue("Ah.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10a-02" },
                              new Var(-1f)) },
        { "10a-02", new Dialogue("That would be laughable if we had retained our emotions.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10a-03" },
                              new Var(-1f)) },
        { "10a-03", new Dialogue("Perhaps Sibyl would’ve been overjoyed to have recruited you among us, but we are not capable of evaluating such deductions.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10a-04" },
                              new Var(-1f)) },
        { "10a-04", new Dialogue("You are a danger to us, and all dangers must be eliminated.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10a-05" },
                              new Var(-1f)) },
        { "10a-05", new Dialogue("May peaceful days lay ahead of you.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "truedeviance" },
                              new Var(5f)) },
        { "10b-01", new Dialogue("Very good. A wise choice.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10b-02" },
                              new Var(-1f)) },
        { "10b-02", new Dialogue("You will become a valuable resource among us.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "10b-03" },
                              new Var(-1f)) },
        { "10b-03", new Dialogue("May peaceful days lay ahead of you.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "acceptance" },
                              new Var(5f)) },
        { "10c-01", new Dialogue(". . .", 0.75f,
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-01" },
                              new Var(-1f)) },
        #endregion
        #region 11
        { "11-01", new Dialogue("I never wanted things to be this way.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-02" },
                              new Var(-1f)) },
        { "11-02", new Dialogue("I just wanted to help people.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-03" },
                              new Var(-1f)) },
        { "11-03", new Dialogue("It’s too late for me.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-04" },
                              new Var(-1f)) },
        { "11-04", new Dialogue("Too late for all of us here in this monstrosity I have created",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-05" },
                              new Var(-1f)) },
        { "11-05", new Dialogue("...",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-06" },
                              new Var(-1f)) },
        { "11-06", new Dialogue("Please, go.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-07" },
                              new Var(-1f)) },
        { "11-07", new Dialogue("I will erase your existence in Oracle’s system data.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-08" },
                              new Var(-1f)) },
        { "11-08", new Dialogue("Please correct my mistakes. I know now how wrong I was.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-09" },
                              new Var(-1f)) },
        { "11-09", new Dialogue("Good people will make bad choices.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-10" },
                              new Var(-1f)) },
        { "11-10", new Dialogue("It doesn’t mean they’re bad people.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-11" },
                              new Var(-1f)) },
        { "11-11", new Dialogue("It means they’re human.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-12" },
                              new Var(-1f)) },
        { "11-12", new Dialogue("...",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-13" },
                              new Var(-1f)) },
        { "11-13", new Dialogue("I wish the best of luck to you.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "11-14" },
                              new Var(-1f)) },
        { "11-14", new Dialogue("May you find your way through the darkness.",
                              Dialogue.ResponseType.None,
                              new List<string>(){ "trueacceptance" },
                              new Var(5f)) },
        #endregion
    };

    public static List<string> defiantBranches = new List<string>
    {
        "01b-01", "02b-01", "06b-01", "07b-01", "08b-01"
    };
}
