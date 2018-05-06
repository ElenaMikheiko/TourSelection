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
    [TechTalk.SpecRun.FeatureAttribute("To change table view of Students table", Description="In order I can work with table with more comfort\r\nAs HR\r\nI should have possibilit" +
        "y to change table view of Students table", SourceFile="FeatureFiles\\_6\\6.2 To change table view of Student\'s table.feature", SourceLine=5)]
    public partial class ToChangeTableViewOfStudentsTableFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "6.2 To change table view of Student's table.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "To change table view of Students table", "In order I can work with table with more comfort\r\nAs HR\r\nI should have possibilit" +
                    "y to change table view of Students table", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Checks possibility to choose table display view", SourceLine=15)]
        public virtual void HRChecksPossibilityToChooseTableDisplayView()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Checks possibility to choose table display view", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 17
testRunner.Then("I can see possibility to choose table display view", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
testRunner.And("I see placeholder text \"Show columns\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR chooses columns to be displayed", SourceLine=19)]
        public virtual void HRChoosesColumnsToBeDisplayed()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR chooses columns to be displayed", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 21
testRunner.Then("I can choose columns to be displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR chooses columns to be hidden", SourceLine=22)]
        public virtual void HRChoosesColumnsToBeHidden()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR chooses columns to be hidden", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 24
testRunner.Then("I can choose columns to be hidden", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Chooses table display view", SourceLine=25)]
        public virtual void HRChoosesTableDisplayView()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Chooses table display view", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 27
testRunner.When("I click on \"Show columns\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
testRunner.Then("drop-down list opens", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
testRunner.And("I can choose options", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField(string option, string column, string number, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sees Order of options in drop-down in \"Show columns\" field", exampleTags);
#line 31
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 32
testRunner.When("I open drop-down list in \"Show columns\" field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
testRunner.Then(string.Format("I see that \"<column>\" is \"{0}\" in drop-down in \"Show columns\" field", number), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option1", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option1()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option1", "Show all", "1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option2", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option2()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option2", "Stream", "2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option3", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option3()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option3", "Name rus", "3", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option4", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option4()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option4", "Surname rus", "4", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option5", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option5()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option5", "Date of birth", "5", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option6", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option6()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option6", "E-mail", "6", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option7", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option7()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option7", "Phone", "7", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option8", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option8()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option8", "Trainer", "8", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option9", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option9()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option9", "Date of graduate", "9", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option10", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option10()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option10", "Final score", "10", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option11", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option11()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option11", "Companies, where recommended", "11", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option12", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option12()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option12", "Employer company", "12", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option13", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option13()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option13", "Recommendation/employment date", "13", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option14", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option14()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option14", "Resume status", "14", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option15", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option15()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option15", "Comments", "15", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option16", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option16()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option16", "Education", "16", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option17", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option17()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option17", "Language", "17", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option18", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option18()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option18", "Language level", "18", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option19", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option19()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option19", "Skills", "19", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Order of options in drop-down in \"Show columns\" field, option20", SourceLine=35)]
        public virtual void HRSeesOrderOfOptionsInDrop_DownInShowColumnsField_Option20()
        {
#line 31
this.HRSeesOrderOfOptionsInDrop_DownInShowColumnsField("option20", "Looking for a job", "20", ((string[])(null)));
#line hidden
        }
        
        public virtual void HRSeesDisplayedTableColumns(string option, string checkbox_Status, string column_Name, string column_Status, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sees Displayed table columns", exampleTags);
#line 57
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 58
testRunner.When(string.Format("I choose \"{0}\" \"{1}\"", checkbox_Status, column_Name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
testRunner.Then(string.Format("column is \"{0}\"", column_Status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Displayed table columns, option1", SourceLine=61)]
        public virtual void HRSeesDisplayedTableColumns_Option1()
        {
#line 57
this.HRSeesDisplayedTableColumns("option1", "tick", "Phone", "displayed", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Displayed table columns, option2", SourceLine=61)]
        public virtual void HRSeesDisplayedTableColumns_Option2()
        {
#line 57
this.HRSeesDisplayedTableColumns("option2", "tick", "Trainer", "displayed", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Displayed table columns, option3", SourceLine=61)]
        public virtual void HRSeesDisplayedTableColumns_Option3()
        {
#line 57
this.HRSeesDisplayedTableColumns("option3", "empty", "Comments", "hidden", ((string[])(null)));
#line hidden
        }
        
        public virtual void HRSeesTableColumnsOrder(string option, string column_Name, string number_Dropdown, string number_Table, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sees Table columns order", exampleTags);
#line 66
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 67
testRunner.When(string.Format("\"{0}\" is \"{1}\" in list in \"Show columns\" field", column_Name, number_Dropdown), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
testRunner.Then(string.Format("\"{0}\" is \"{1}\" in table", column_Name, number_Table), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Table columns order, option1", SourceLine=70)]
        public virtual void HRSeesTableColumnsOrder_Option1()
        {
#line 66
this.HRSeesTableColumnsOrder("option1", "Stream", "1", "1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Table columns order, option2", SourceLine=70)]
        public virtual void HRSeesTableColumnsOrder_Option2()
        {
#line 66
this.HRSeesTableColumnsOrder("option2", "Name rus", "2", "2", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Table columns order, option3", SourceLine=70)]
        public virtual void HRSeesTableColumnsOrder_Option3()
        {
#line 66
this.HRSeesTableColumnsOrder("option3", "E-mail", "5", "5", ((string[])(null)));
#line hidden
        }
        
        public virtual void HRSeesTableColumnsNumber(string option, string number_Dropdown, string number_Table, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR sees Table columns number", exampleTags);
#line 75
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 76
testRunner.When(string.Format("there is \"{0}\" column\'s names in list in \"Show columns\" field", number_Dropdown), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
testRunner.Then(string.Format("there is \"{0}\" columns in table", number_Table), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Table columns number, option1", SourceLine=79)]
        public virtual void HRSeesTableColumnsNumber_Option1()
        {
#line 75
this.HRSeesTableColumnsNumber("option1", "5", "5", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Table columns number, option2", SourceLine=79)]
        public virtual void HRSeesTableColumnsNumber_Option2()
        {
#line 75
this.HRSeesTableColumnsNumber("option2", "7", "7", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR sees Table columns number, option3", SourceLine=79)]
        public virtual void HRSeesTableColumnsNumber_Option3()
        {
#line 75
this.HRSeesTableColumnsNumber("option3", "10", "10", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Opens drop-down", new string[] {
                "UI"}, SourceLine=85)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void HROpensDrop_Down()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Opens drop-down", new string[] {
                        "ignore",
                        "UI"});
#line 86
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 87
 testRunner.When("I click on area of drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
 testRunner.Then("drop-down is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("HR Closes drop-down", new string[] {
                "UI"}, SourceLine=91)]
        [TechTalk.SpecRun.IgnoreAttribute()]
        public virtual void HRClosesDrop_Down()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("HR Closes drop-down", new string[] {
                        "ignore",
                        "UI"});
#line 92
this.ScenarioSetup(scenarioInfo);
#line 11
this.FeatureBackground();
#line 93
 testRunner.When("I click outside area of drop-down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 94
 testRunner.Then("drop-down is hidden", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
