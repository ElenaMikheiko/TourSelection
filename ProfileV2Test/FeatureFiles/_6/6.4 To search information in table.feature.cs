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
    [TechTalk.SpecRun.FeatureAttribute("To search information in table", Description="In order I can find information I need\r\nAs HR\r\nI should have possibility to searc" +
        "h information in table", SourceFile="FeatureFiles\\_6\\6.4 To search information in table.feature", SourceLine=5)]
    public partial class ToSearchInformationInTableFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "6.4 To search information in table.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "To search information in table", "In order I can find information I need\r\nAs HR\r\nI should have possibility to searc" +
                    "h information in table", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks possibility to search information in table", SourceLine=15)]
        public virtual void HRChecksPossibilityToSearchInformationInTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks possibility to search information in table", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 17
testRunner.Then("I can see possibility to search information in table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Searches information", SourceLine=18)]
        public virtual void HRSearchesInformation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Searches information", ((string[])(null)));
#line 19
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 20
testRunner.When("I click in \"Search\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
testRunner.Then("I can type text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksInSearchInputField(string option, string letters, string elements, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Validation"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
                    "rs 0-9, punctuation marks in \"Search\" input field", @__tags);
#line 24
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 25
testRunner.When(string.Format("I write \"{0}\" in \"Search\" input field", letters), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
testRunner.Then(string.Format("I see the written \"{0}\"", elements), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks in \"Search\" input field, option1", new string[] {
                "Validation"}, SourceLine=28)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksInSearchInputField_Option1()
        {
#line 24
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksInSearchInputField("option1", "АБВгде", "АБВгде", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks in \"Search\" input field, option2", new string[] {
                "Validation"}, SourceLine=28)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksInSearchInputField_Option2()
        {
#line 24
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksInSearchInputField("option2", "`\"№%*_=+ @#$^&", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks in \"Search\" input field, option3", new string[] {
                "Validation"}, SourceLine=28)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksInSearchInputField_Option3()
        {
#line 24
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksInSearchInputField("option3", "ABCdef", "ABCdef", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks in \"Search\" input field, option4", new string[] {
                "Validation"}, SourceLine=28)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksInSearchInputField_Option4()
        {
#line 24
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksInSearchInputField("option4", ".,:;!?`-()", ".,:;!?`-()", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Allowed symbols English letters A-Z, a-z, Russian letters А-Я, а-я, numbe" +
            "rs 0-9, punctuation marks in \"Search\" input field, option5", new string[] {
                "Validation"}, SourceLine=28)]
        public virtual void HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksInSearchInputField_Option5()
        {
#line 24
this.HRSeesAllowedSymbolsEnglishLettersA_ZA_ZRussianLettersА_ЯА_ЯNumbers0_9PunctuationMarksInSearchInputField("option5", "0123456789", "0123456789", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR starts Search", SourceLine=34)]
        public virtual void HRStartsSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR starts Search", ((string[])(null)));
#line 35
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 36
testRunner.When("I click on \"Search\" icon or press \"Enter\" on keyboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
testRunner.Then("search starts", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void HRSeesSearchResultsPositive(string option, string number_Letters, string letters, string number_Highlighted, string phrase, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sees Search results positive", exampleTags);
#line 39
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 40
testRunner.When(string.Format("I type \"{0}\" \"{1}\" in \"Search\" field", number_Letters, letters), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
testRunner.Then(string.Format("I see occuring \"{0}\" is highlighted in {1}", number_Highlighted, phrase), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Search results positive, option1", SourceLine=43)]
        public virtual void HRSeesSearchResultsPositive_Option1()
        {
#line 39
this.HRSeesSearchResultsPositive("option1", "3", "абв", "0", "", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Search results positive, option2", SourceLine=43)]
        public virtual void HRSeesSearchResultsPositive_Option2()
        {
#line 39
this.HRSeesSearchResultsPositive("option2", "5", "ивано", "5", "ивано, иванов, иванова, иванович, ивановна", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Search results positive, option3", SourceLine=43)]
        public virtual void HRSeesSearchResultsPositive_Option3()
        {
#line 39
this.HRSeesSearchResultsPositive("option3", "7", "english", "7", "english", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Search results negative", SourceLine=47)]
        public virtual void HRSeesSearchResultsNegative()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sees Search results negative", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 49
testRunner.When("I see occuring <number_highlighted> =0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
testRunner.Then("I see notification \"No match is found\" in \"Search\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Removes highlighting on words", new string[] {
                "UI"}, SourceLine=52)]
        public virtual void HRRemovesHighlightingOnWords()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Removes highlighting on words", new string[] {
                        "UI"});
#line 53
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 54
testRunner.When("I press on any place on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
testRunner.Then("highlighting on words is hidden", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
