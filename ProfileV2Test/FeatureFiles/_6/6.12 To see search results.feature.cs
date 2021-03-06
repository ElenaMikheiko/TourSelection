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
    [TechTalk.SpecRun.FeatureAttribute("To see search results", Description="  In order I can find information I need\r\n  As HR\r\n  I should have possibility to" +
        " see search results", SourceFile="FeatureFiles\\_6\\6.12 To see search results.feature", SourceLine=5)]
    public partial class ToSeeSearchResultsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "6.12 To see search results.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "To see search results", "  In order I can find information I need\r\n  As HR\r\n  I should have possibility to" +
                    " see search results", ProgrammingLanguage.CSharp, ((string[])(null)));
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
testRunner.And("I stay on home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
testRunner.Given("I chose search options in Students table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Starts search", SourceLine=16)]
        public virtual void HRStartsSearch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Starts search", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 18
 testRunner.When("I start to choose search option in another table column", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 19
 testRunner.Then("search filter is applied immediately", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"№\" column in search result table", SourceLine=20)]
        public virtual void HRChecksDataInColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"№\" column in search result table", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 22
 testRunner.When("I see column \"№\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
 testRunner.Then("I see Student\'s index number in list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Ticks option in column \"Choose\" in search result table", SourceLine=24)]
        public virtual void HRTicksOptionInColumnChooseInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Ticks option in column \"Choose\" in search result table", ((string[])(null)));
#line 25
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 26
 testRunner.When("I see column \"Choose\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("I can tick option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Stream\" column in search result table", SourceLine=28)]
        public virtual void HRChecksDataInStreamColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Stream\" column in search result table", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 30
 testRunner.When("I see column \"Stream\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("I see Stream information from database corresponding to the search option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Name rus\" column in search result table", SourceLine=32)]
        public virtual void HRChecksDataInNameRusColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Name rus\" column in search result table", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 34
 testRunner.When("I see column \"Name rus\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 35
 testRunner.Then("I see Name information from database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Surname rus\" column in search result table", SourceLine=36)]
        public virtual void HRChecksDataInSurnameRusColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Surname rus\" column in search result table", ((string[])(null)));
#line 37
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 38
 testRunner.When("I see column \"Surname rus\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("I see Surname information from database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Date of birth\" column in search result table", SourceLine=40)]
        public virtual void HRChecksDataInDateOfBirthColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Date of birth\" column in search result table", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 42
 testRunner.When("I see column \"Date of birth\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("I see  Date of birth information from database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"E-mail\" column in search result table", SourceLine=44)]
        public virtual void HRChecksDataInE_MailColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"E-mail\" column in search result table", ((string[])(null)));
#line 45
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 46
 testRunner.When("I see column \"E-mail\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
 testRunner.Then("I see E-mail information from database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Phone\" column in search result table", SourceLine=48)]
        public virtual void HRChecksDataInPhoneColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Phone\" column in search result table", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 50
 testRunner.When("I see column \"Phone\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("I see Phone information from database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Trainer\" column in search result table", SourceLine=52)]
        public virtual void HRChecksDataInTrainerColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Trainer\" column in search result table", ((string[])(null)));
#line 53
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 54
 testRunner.When("I see column \"Trainer\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 55
 testRunner.Then("I see Trainer information from database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Date of graduate\" column in search result table", SourceLine=56)]
        public virtual void HRChecksDataInDateOfGraduateColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Date of graduate\" column in search result table", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 58
 testRunner.When("I see column \"Date of graduate\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
 testRunner.Then("I see Date of graduate information from database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Final score\" column in search result table", SourceLine=60)]
        public virtual void HRChecksDataInFinalScoreColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Final score\" column in search result table", ((string[])(null)));
#line 61
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 62
 testRunner.When("I see column \"Final score\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then("I see Score information from database corresponding to the search option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Companies, where recommended\" column in search result table", SourceLine=64)]
        public virtual void HRChecksDataInCompaniesWhereRecommendedColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Companies, where recommended\" column in search result table", ((string[])(null)));
#line 65
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 66
 testRunner.When("I see column \"Companies, where recommended\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("I see Company information from database corresponding to the search option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Employer company\" column in search result table", SourceLine=68)]
        public virtual void HRChecksDataInEmployerCompanyColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Employer company\" column in search result table", ((string[])(null)));
#line 69
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 70
 testRunner.When("I see column \"Employer company\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.Then("I see Company information from database corresponding to the search option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Recommendation/employment date\" column in search result table", SourceLine=72)]
        public virtual void HRChecksDataInRecommendationEmploymentDateColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Recommendation/employment date\" column in search result table", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 74
 testRunner.When("I see column \"Recommendation/employment date\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 75
 testRunner.Then("I see dates from database corresponding to search option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Resume status\" column in search result table", SourceLine=76)]
        public virtual void HRChecksDataInResumeStatusColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Resume status\" column in search result table", ((string[])(null)));
#line 77
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 78
 testRunner.When("I see column \"Resume status\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 79
 testRunner.Then("I see Status information from database corresponding to the search option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Comments\" column in search result table", SourceLine=80)]
        public virtual void HRChecksDataInCommentsColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Comments\" column in search result table", ((string[])(null)));
#line 81
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 82
 testRunner.When("I see column \"Comments\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 83
 testRunner.Then("I see Comments information from database", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Education\" column in search result table", SourceLine=84)]
        public virtual void HRChecksDataInEducationColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Education\" column in search result table", ((string[])(null)));
#line 85
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 86
 testRunner.When("I see column \"Education\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
 testRunner.Then("I see Education information from database corresponding to search option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Language\" column in search result table", SourceLine=88)]
        public virtual void HRChecksDataInLanguageColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Language\" column in search result table", ((string[])(null)));
#line 89
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 90
 testRunner.When("I see column \"Language\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 91
 testRunner.Then("I see Language information from database corresponding to search option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Language level\" column in search result table", SourceLine=92)]
        public virtual void HRChecksDataInLanguageLevelColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Language level\" column in search result table", ((string[])(null)));
#line 93
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 94
 testRunner.When("I see column \"Language level\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("I see Language level information from database corresponding to search option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Skills\" column in search result table", SourceLine=96)]
        public virtual void HRChecksDataInSkillsColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Skills\" column in search result table", ((string[])(null)));
#line 97
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 98
 testRunner.When("I see column \"Skills\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
 testRunner.Then("I see Skills information from database corresponding to search option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks data in \"Looking for a job\" column in search result table", SourceLine=100)]
        public virtual void HRChecksDataInLookingForAJobColumnInSearchResultTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks data in \"Looking for a job\" column in search result table", ((string[])(null)));
#line 101
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 102
 testRunner.When("I see column \"Looking for a job\" in search result table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
 testRunner.Then("I see information from database corresponding to search option", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR chooses Search options", SourceLine=111)]
        public virtual void HRChoosesSearchOptions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR chooses Search options", ((string[])(null)));
#line 112
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 113
 testRunner.When("I chose search options in search table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
 testRunner.Then("not all options should be chosen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
