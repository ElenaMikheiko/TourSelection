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
namespace ProfileV2Test.FeatureFiles._5
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("5.19 To return to last step of filling in resume", Description="In order I can finish to fill in my resume\r\nAs Student\r\nI should have possibility" +
        " to return to my last step in resume", SourceFile="FeatureFiles\\_5\\5.19 To return to last step of filling in resume.feature", SourceLine=0)]
    public partial class _5_19ToReturnToLastStepOfFillingInResumeFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "5.19 To return to last step of filling in resume.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "5.19 To return to last step of filling in resume", "In order I can finish to fill in my resume\r\nAs Student\r\nI should have possibility" +
                    " to return to my last step in resume", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void StudentReturnsToLastStepOfHisResume(string option, string student, string block_Name, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Student returns to last step of his resume", exampleTags);
#line 6
   this.ScenarioSetup(scenarioInfo);
#line 7
      testRunner.Given("As unauthorised user I come to landing page of Profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
      testRunner.And(string.Format("I log in as \'{0}\'", student), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
      testRunner.And("I open my personal menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
      testRunner.And("I select button \"Resume\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
   testRunner.And("I start or continue filling in my resume", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
      testRunner.And(string.Format("I pressed button “CANCEL” in \'{0}\'", block_Name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
      testRunner.And("I open my personal menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
   testRunner.And("I select button \"Resume\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
      testRunner.Then(string.Format("I moved to block \"{0}\"", block_Name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student returns to last step of his resume, option2", SourceLine=17)]
        public virtual void StudentReturnsToLastStepOfHisResume_Option2()
        {
#line 6
   this.StudentReturnsToLastStepOfHisResume("option2", "Pavel Jones", "Objective", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student returns to last step of his resume, option3", SourceLine=17)]
        public virtual void StudentReturnsToLastStepOfHisResume_Option3()
        {
#line 6
   this.StudentReturnsToLastStepOfHisResume("option3", "Nikola Brown", "Summary", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student returns to last step of his resume, option4", SourceLine=17)]
        public virtual void StudentReturnsToLastStepOfHisResume_Option4()
        {
#line 6
   this.StudentReturnsToLastStepOfHisResume("option4", "Vlad Davies", "Skills", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student returns to last step of his resume, option5", SourceLine=17)]
        public virtual void StudentReturnsToLastStepOfHisResume_Option5()
        {
#line 6
   this.StudentReturnsToLastStepOfHisResume("option5", "Victor Willians", "Foreign languages", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student returns to last step of his resume, option6", SourceLine=17)]
        public virtual void StudentReturnsToLastStepOfHisResume_Option6()
        {
#line 6
   this.StudentReturnsToLastStepOfHisResume("option6", "Sveta Evans", "Education", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student returns to last step of his resume, option7", SourceLine=17)]
        public virtual void StudentReturnsToLastStepOfHisResume_Option7()
        {
#line 6
   this.StudentReturnsToLastStepOfHisResume("option7", "Nadejda Moore", "Professional development, courses", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student returns to last step of his resume, option8", SourceLine=17)]
        public virtual void StudentReturnsToLastStepOfHisResume_Option8()
        {
#line 6
   this.StudentReturnsToLastStepOfHisResume("option8", "Lena Taylor", "Electronic certificates, tests, exams", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student returns to last step of his resume, option9", SourceLine=17)]
        public virtual void StudentReturnsToLastStepOfHisResume_Option9()
        {
#line 6
   this.StudentReturnsToLastStepOfHisResume("option9", "Emily Tomas", "Work experience", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student returns to last step of his resume, option10", SourceLine=17)]
        public virtual void StudentReturnsToLastStepOfHisResume_Option10()
        {
#line 6
   this.StudentReturnsToLastStepOfHisResume("option10", "Sophie Miler", "Portfolio", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student returns to last step of his resume, option11", SourceLine=17)]
        public virtual void StudentReturnsToLastStepOfHisResume_Option11()
        {
#line 6
   this.StudentReturnsToLastStepOfHisResume("option11", "Ruby Javovich", "Military status", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student returns to last step of his resume, option12", SourceLine=17)]
        public virtual void StudentReturnsToLastStepOfHisResume_Option12()
        {
#line 6
   this.StudentReturnsToLastStepOfHisResume("option12", "Oliver Wilson", "Additional information", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Student returns to last step of his resume, option13", SourceLine=17)]
        public virtual void StudentReturnsToLastStepOfHisResume_Option13()
        {
#line 6
   this.StudentReturnsToLastStepOfHisResume("option13", "Jack Daniel\'s", "Recommendations", ((string[])(null)));
#line hidden
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
