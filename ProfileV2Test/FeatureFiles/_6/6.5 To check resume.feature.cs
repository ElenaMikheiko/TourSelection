﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ProfileV2Test.FeatureFiles._6
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("To check resume", Description="  In order I can correct resume\r\n  As HR\r\n  I should have possibility to check re" +
        "sume", SourceFile="FeatureFiles\\_6\\6.5 To check resume.feature", SourceLine=5)]
    public partial class ToCheckResumeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "6.5 To check resume.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "To check resume", "  In order I can correct resume\r\n  As HR\r\n  I should have possibility to check re" +
                    "sume", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 11
#line 12
testRunner.Given("As unauthorised user I come to landing page of Profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
testRunner.And("I log in as HR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
testRunner.And("I see page HR\'s list of students", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.And("I opened Student\'s resume", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks resume", SourceLine=16)]
        public virtual void HRChecksResume()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks resume", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 18
 testRunner.Then("I can check Student\'s resume", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Leaves comments on resume", SourceLine=19)]
        public virtual void HRLeavesCommentsOnResume()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Leaves comments on resume", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 21
 testRunner.Then("I can leave comments on Student\'s resume", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Leaves comments for HR", SourceLine=22)]
        public virtual void HRLeavesCommentsForHR()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Leaves comments for HR", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 24
 testRunner.Then("I can leave comments for HR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Sees hint", SourceLine=25)]
        public virtual void HRSeesHint()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Sees hint", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "TEXT"});
            table1.AddRow(new string[] {
                        "To add a comment to a resume block please click on a resume block title."});
#line 27
 testRunner.Then("I can see hint text", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Types text", SourceLine=30)]
        public virtual void HRTypesText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Types text", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 32
 testRunner.When("I click on resume title", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then("I can type text in resume block", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR checks Text color", SourceLine=34)]
        public virtual void HRChecksTextColor()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR checks Text color", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 36
 testRunner.When("I type text in resume block", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("I see text is red color", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Saves text", SourceLine=38)]
        public virtual void HRSavesText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Saves text", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 40
 testRunner.Given("I type text in resume block", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
 testRunner.When("I press on \"SAVE\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.Then("Information is saved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Deletes text", SourceLine=43)]
        public virtual void HRDeletesText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Deletes text", ((string[])(null)));
#line 44
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 45
 testRunner.Given("I type text in resume block", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 46
 testRunner.When("I press button with cross", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("I text in resume block is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Chooses option", SourceLine=48)]
        public virtual void HRChoosesOption()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Chooses option", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 50
 testRunner.When("I click on resume title", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("I can choose option in resume block", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Edits resume", SourceLine=52)]
        public virtual void HREditsResume()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Edits resume", ((string[])(null)));
#line 53
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 54
 testRunner.Then("I can edit resume", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.And("I can edit resume block \"Personal and contact information\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And("I can edit resume block \"Objective\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("I can edit resume block \"Summary\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("I can edit resume block \"Skills\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("I can edit resume block \"Foreign languages\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("I can edit resume block \"Education\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("I can edit resume block \"Professional development, courses\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And("I can edit resume block \"Electronic certificates, tests, examinations\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("I can edit resume block \"Work experience\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
 testRunner.And("I can edit resume block \"Portfolio\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("I can edit resume block \"Military status\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("I can edit resume block \"Additional information\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("I can edit resume block \"Recommendations\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsOnResume(string option, string letters, string elements, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Validation"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
                    "rs 0-9, punctuation marks, symbols in field \"Comments on resume\"", @__tags);
#line 70
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 71
 testRunner.When(string.Format("I write \"{0}\" in  input field \"Comments on resume\"", letters), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
 testRunner.Then(string.Format("I see the written \"{0}\"", elements), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks, symbols in field \"Comments on resume\", option1", new string[] {
                "Validation"}, SourceLine=74)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsOnResume_Option1()
        {
#line 70
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsOnResume("option1", "АБВгде", "АБВгде", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks, symbols in field \"Comments on resume\", option2", new string[] {
                "Validation"}, SourceLine=74)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsOnResume_Option2()
        {
#line 70
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsOnResume("option2", "`\"№%*_=+ @#$^&", "`\"№%*_=+ @#$^&", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks, symbols in field \"Comments on resume\", option3", new string[] {
                "Validation"}, SourceLine=74)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsOnResume_Option3()
        {
#line 70
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsOnResume("option3", "ABCdef", "ABCdef", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks, symbols in field \"Comments on resume\", option4", new string[] {
                "Validation"}, SourceLine=74)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsOnResume_Option4()
        {
#line 70
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsOnResume("option4", ".,:;!?`-()", ".,:;!?`-()", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks, symbols in field \"Comments on resume\", option5", new string[] {
                "Validation"}, SourceLine=74)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsOnResume_Option5()
        {
#line 70
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsOnResume("option5", "0123456789", "0123456789", ((string[])(null)));
#line hidden
        }
        
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsForHR(string option, string letters, string elements, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Validation"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
                    "rs 0-9, punctuation marks, symbols in field \"Comments for HR\"", @__tags);
#line 82
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 83
 testRunner.When(string.Format("I write \"{0}\" in  input field \"Comments for HR\"", letters), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.Then(string.Format("I see the written \"{0}\"", elements), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks, symbols in field \"Comments for HR\", option1", new string[] {
                "Validation"}, SourceLine=86)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsForHR_Option1()
        {
#line 82
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsForHR("option1", "АБВгде", "АБВгде", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks, symbols in field \"Comments for HR\", option2", new string[] {
                "Validation"}, SourceLine=86)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsForHR_Option2()
        {
#line 82
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsForHR("option2", "`\"№%*_=+ @#$^&", "`\"№%*_=+ @#$^&", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks, symbols in field \"Comments for HR\", option3", new string[] {
                "Validation"}, SourceLine=86)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsForHR_Option3()
        {
#line 82
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsForHR("option3", "ABCdef", "ABCdef", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks, symbols in field \"Comments for HR\", option4", new string[] {
                "Validation"}, SourceLine=86)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsForHR_Option4()
        {
#line 82
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsForHR("option4", ".,:;!?`-()", ".,:;!?`-()", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks, symbols in field \"Comments for HR\", option5", new string[] {
                "Validation"}, SourceLine=86)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsForHR_Option5()
        {
#line 82
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksSymbolsInFieldCommentsForHR("option5", "0123456789", "0123456789", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Chooses value in field \"Education\"", SourceLine=92)]
        public virtual void HRChoosesValueInFieldEducation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Chooses value in field \"Education\"", ((string[])(null)));
#line 93
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 94
testRunner.When("I see radio buttons in field \"Education\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
testRunner.Then("I can choose value \"Technical\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
testRunner.And("I can choose value \"Non-technical\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Chooses value in field \"Archive\"", SourceLine=97)]
        public virtual void HRChoosesValueInFieldArchive()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Chooses value in field \"Archive\"", ((string[])(null)));
#line 98
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 99
testRunner.When("I see radio buttons in field \"\"Archive\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 100
testRunner.Then("I can choose value \"Employed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
testRunner.And("I can choose value \"Unemployed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
testRunner.And("I can choose value \"Didn\'t participate in the program\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sets Student\'s resume status \"Archive Employed\"", SourceLine=103)]
        public virtual void HRSetsStudentsResumeStatusArchiveEmployed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sets Student\'s resume status \"Archive Employed\"", ((string[])(null)));
#line 104
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 105
testRunner.When("I choose value \"Employed\" in field \"\"Archive\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 106
testRunner.Then("Student\'s resume status =\"Archive Employed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sets Student\'s resume status \"Archive Unemployed\"", SourceLine=107)]
        public virtual void HRSetsStudentsResumeStatusArchiveUnemployed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sets Student\'s resume status \"Archive Unemployed\"", ((string[])(null)));
#line 108
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 109
testRunner.When("I choose value \"Unemployed\" in field \"\"Archive\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
testRunner.Then("Student\'s resume status =\"Archive Unemployed\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sets Student\'s resume status \"Archive Didn\'t participate in the program\"", SourceLine=111)]
        public virtual void HRSetsStudentsResumeStatusArchiveDidntParticipateInTheProgram()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sets Student\'s resume status \"Archive Didn\'t participate in the program\"", ((string[])(null)));
#line 112
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 113
testRunner.When("I choose value \"Didn\'t participate in the program\" in field \"\"Archive\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
testRunner.Then("Student\'s resume status =\"Archive Didn\'t participate in the program\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Deletes comment on resume", SourceLine=115)]
        public virtual void HRDeletesCommentOnResume()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Deletes comment on resume", ((string[])(null)));
#line 116
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 117
 testRunner.Given("I wrote comment on resume block", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 118
 testRunner.When("I click button with cross", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
 testRunner.Then("my comment on resume block is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Deletes comment for HR", SourceLine=120)]
        public virtual void HRDeletesCommentForHR()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Deletes comment for HR", ((string[])(null)));
#line 121
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 122
 testRunner.Given("I wrote comment for HR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 123
 testRunner.When("I click button with cross", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 124
 testRunner.Then("my comment for HR is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Hides comment on resume", SourceLine=125)]
        public virtual void HRHidesCommentOnResume()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Hides comment on resume", ((string[])(null)));
#line 126
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 127
 testRunner.When("I approve resume by clicking button \"APPROVE\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 128
 testRunner.Then("I comments on resume are hidden", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Approves resume", SourceLine=129)]
        public virtual void HRApprovesResume()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Approves resume", ((string[])(null)));
#line 130
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 131
 testRunner.When("I checked resume", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 132
 testRunner.And("I press on \"APPROVE\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.Then("resume is approved", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sets resume status \"Approved\"", SourceLine=134)]
        public virtual void HRSetsResumeStatusApproved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sets resume status \"Approved\"", ((string[])(null)));
#line 135
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 136
 testRunner.When("I press on \"APPROVE\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 137
 testRunner.Then("resume status = \"Approved\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Sends comments", SourceLine=138)]
        public virtual void HRSendsComments()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Sends comments", ((string[])(null)));
#line 139
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 140
 testRunner.Given("I wrote comments on Student\'s resume", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 141
 testRunner.When("I click \"RETURN RESUME\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 142
 testRunner.Then("comments are sent to Student by e-mail", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 143
 testRunner.And("Student receives notification #5.18.2 To receive notification e-mail Comments on " +
                    "resume.feature", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sets resume status \"REVIEW\"", SourceLine=144)]
        public virtual void HRSetsResumeStatusREVIEW()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sets resume status \"REVIEW\"", ((string[])(null)));
#line 145
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 146
 testRunner.When("I press on \"RETURN RESUME\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 147
 testRunner.Then("resume status = \"Review\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Moves to previous page", SourceLine=148)]
        public virtual void HRMovesToPreviousPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Moves to previous page", ((string[])(null)));
#line 149
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 150
    testRunner.When("I choose to go to previous page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 151
    testRunner.Then("I move to previously opened page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR can see Button \"APPROVE\" is highlighted on hover", new string[] {
                "UI"}, SourceLine=153)]
        public virtual void HRCanSeeButtonAPPROVEIsHighlightedOnHover()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR can see Button \"APPROVE\" is highlighted on hover", new string[] {
                        "UI"});
#line 154
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 155
 testRunner.When("I hover on \"APPROVE\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 156
 testRunner.Then("Button \"APPROVE\" is highlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR can see Button \"APPROVE\" is active by default", new string[] {
                "UI"}, SourceLine=158)]
        public virtual void HRCanSeeButtonAPPROVEIsActiveByDefault()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR can see Button \"APPROVE\" is active by default", new string[] {
                        "UI"});
#line 159
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 160
 testRunner.Then("Button \"APPROVE\" is active by default", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR can see Button \"RETURN RESUME\" is highlighted on hover", new string[] {
                "UI"}, SourceLine=162)]
        public virtual void HRCanSeeButtonRETURNRESUMEIsHighlightedOnHover()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR can see Button \"RETURN RESUME\" is highlighted on hover", new string[] {
                        "UI"});
#line 163
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 164
 testRunner.When("I hover on \"RETURN RESUME\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 165
 testRunner.Then("Button \"RETURN RESUME\" is highlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR can see Button \"BACK\" is highlighted on hover", new string[] {
                "UI"}, SourceLine=167)]
        public virtual void HRCanSeeButtonBACKIsHighlightedOnHover()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR can see Button \"BACK\" is highlighted on hover", new string[] {
                        "UI"});
#line 168
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 169
 testRunner.When("I hover on \"BACK\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 170
 testRunner.Then("Button \"BACK\" is highlighted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
