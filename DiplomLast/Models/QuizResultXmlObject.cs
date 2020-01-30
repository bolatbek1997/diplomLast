using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiplomLast.Models
{

    public class QuizResultXmlObject
    {
            // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults", IsNullable = false)]
            public partial class quizReport
            {

                public quizReportQuizSettings quizSettingsField;

                public quizReportSummary summaryField;

                public quizReportQuestions questionsField;

                public byte versionField;

                /// <remarks/>
                public quizReportQuizSettings quizSettings
                {
                    get
                    {
                        return this.quizSettingsField;
                    }
                    set
                    {
                        this.quizSettingsField = value;
                    }
                }

                /// <remarks/>
                public quizReportSummary summary
                {
                    get
                    {
                        return this.summaryField;
                    }
                    set
                    {
                        this.summaryField = value;
                    }
                }

                /// <remarks/>
                public quizReportQuestions questions
                {
                    get
                    {
                        return this.questionsField;
                    }
                    set
                    {
                        this.questionsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte version
                {
                    get
                    {
                        return this.versionField;
                    }
                    set
                    {
                        this.versionField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuizSettings
            {

                public decimal passingPercentField;

                public string quizTypeField;

                public int maxScoreField;

                public decimal maxNormalizedScoreField;

                public ushort timeLimitField;
                public string allTime { get; set; }

                /// <remarks/>
                public decimal passingPercent
                {
                    get
                    {
                        return this.passingPercentField;
                    }
                    set
                    {
                        this.passingPercentField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string quizType
                {
                    get
                    {
                        return this.quizTypeField;
                    }
                    set
                    {
                        this.quizTypeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public int maxScore
                {
                    get
                    {
                        return this.maxScoreField;
                    }
                    set
                    {
                        this.maxScoreField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public decimal maxNormalizedScore
                {
                    get
                    {
                        return this.maxNormalizedScoreField;
                    }
                    set
                    {
                        this.maxNormalizedScoreField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public ushort timeLimit
                {
                    get
                    {
                        return this.timeLimitField;
                    }
                    set
                    {
                        this.timeLimitField = value;
                    }
                }
            }

            string timeToString(decimal d)
            {
                string s = "";

                return s;
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportSummary
            {

                public quizReportSummaryVariable[] variablesField;

                public decimal scoreField;

                public decimal percentField;

                public decimal timeField;
                public string passingTime { get; set; }

                /// <remarks/>
                public quizReportSummaryVariable[] variables
                {
                    get
                    {
                        return this.variablesField;
                    }
                    set
                    {
                        this.variablesField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public decimal score
                {
                    get
                    {
                        return this.scoreField;
                    }
                    set
                    {
                        this.scoreField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public decimal percent
                {
                    get
                    {
                        return this.percentField;
                    }
                    set
                    {
                        this.percentField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public decimal time
                {
                    get
                    {
                        return this.timeField;
                    }
                    set
                    {
                        this.timeField = value;
                    }
                }
            }
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportSummaryVariable
            {

                public string nameField;

                public string titleField;

                public string valueField;

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string name
                {
                    get
                    {
                        return this.nameField;
                    }
                    set
                    {
                        this.nameField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string title
                {
                    get
                    {
                        return this.titleField;
                    }
                    set
                    {
                        this.titleField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string value
                {
                    get
                    {
                        return this.valueField;
                    }
                    set
                    {
                        this.valueField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestions
            {

                private object[] itemsField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute("essayQuestion", typeof(quizReportQuestionsEssayQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("fillInTheBlankQuestion", typeof(quizReportQuestionsFillInTheBlankQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("fillInTheBlankQuestionEx", typeof(quizReportQuestionsFillInTheBlankQuestionEx))]
                [System.Xml.Serialization.XmlElementAttribute("fillInTheBlankSurveyQuestion", typeof(quizReportQuestionsFillInTheBlankSurveyQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("likertScaleQuestion", typeof(quizReportQuestionsLikertScaleQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("matchingQuestion", typeof(quizReportQuestionsMatchingQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("matchingSurveyQuestion", typeof(quizReportQuestionsMatchingSurveyQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("multipleChoiceQuestion", typeof(quizReportQuestionsMultipleChoiceQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("multipleChoiceTextQuestion", typeof(quizReportQuestionsMultipleChoiceTextQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("multipleChoiceTextSurveyQuestion", typeof(quizReportQuestionsMultipleChoiceTextSurveyQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("multipleResponseQuestion", typeof(quizReportQuestionsMultipleResponseQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("numericQuestion", typeof(quizReportQuestionsNumericQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("numericSurveyQuestion", typeof(quizReportQuestionsNumericSurveyQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("pickManyQuestion", typeof(quizReportQuestionsPickManyQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("pickOneQuestion", typeof(quizReportQuestionsPickOneQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("rankingQuestion", typeof(quizReportQuestionsRankingQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("sequenceQuestion", typeof(quizReportQuestionsSequenceQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("shortAnswerQuestion", typeof(quizReportQuestionsShortAnswerQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("trueFalseQuestion", typeof(quizReportQuestionsTrueFalseQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("whichWordQuestion", typeof(quizReportQuestionsWhichWordQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("wordBankQuestion", typeof(quizReportQuestionsWordBankQuestion))]
                [System.Xml.Serialization.XmlElementAttribute("yesNoQuestion", typeof(quizReportQuestionsYesNoQuestion))]
                public object[] Items
                {
                    get
                    {
                        return this.itemsField;
                    }
                    set
                    {
                        this.itemsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsEssayQuestion
            {

                public string directionField;

                public string userAnswerField;

                public string idField;

                public string statusField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                public string userAnswer
                {
                    get
                    {
                        return this.userAnswerField;
                    }
                    set
                    {
                        this.userAnswerField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsFillInTheBlankQuestion
            {

                public string directionField;

                public quizReportQuestionsFillInTheBlankQuestionAcceptableAnswers acceptableAnswersField;

                public string idField;

                public string statusField;

                public byte maxPointsField;

                public byte maxAttemptsField;

                public byte awardedPointsField;

                public byte usedAttemptsField;

                public string userAnswerField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                public quizReportQuestionsFillInTheBlankQuestionAcceptableAnswers acceptableAnswers
                {
                    get
                    {
                        return this.acceptableAnswersField;
                    }
                    set
                    {
                        this.acceptableAnswersField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxPoints
                {
                    get
                    {
                        return this.maxPointsField;
                    }
                    set
                    {
                        this.maxPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxAttempts
                {
                    get
                    {
                        return this.maxAttemptsField;
                    }
                    set
                    {
                        this.maxAttemptsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte awardedPoints
                {
                    get
                    {
                        return this.awardedPointsField;
                    }
                    set
                    {
                        this.awardedPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte usedAttempts
                {
                    get
                    {
                        return this.usedAttemptsField;
                    }
                    set
                    {
                        this.usedAttemptsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string userAnswer
                {
                    get
                    {
                        return this.userAnswerField;
                    }
                    set
                    {
                        this.userAnswerField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsFillInTheBlankQuestionAcceptableAnswers
            {

                public string answerField;

                /// <remarks/>
                public string answer
                {
                    get
                    {
                        return this.answerField;
                    }
                    set
                    {
                        this.answerField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsFillInTheBlankQuestionEx
            {

                public string directionField;

                public quizReportQuestionsFillInTheBlankQuestionExDetails detailsField;

                public string idField;

                public string statusField;

                public byte maxPointsField;

                public byte maxAttemptsField;

                public byte awardedPointsField;

                public byte usedAttemptsField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                public quizReportQuestionsFillInTheBlankQuestionExDetails details
                {
                    get
                    {
                        return this.detailsField;
                    }
                    set
                    {
                        this.detailsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxPoints
                {
                    get
                    {
                        return this.maxPointsField;
                    }
                    set
                    {
                        this.maxPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxAttempts
                {
                    get
                    {
                        return this.maxAttemptsField;
                    }
                    set
                    {
                        this.maxAttemptsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte awardedPoints
                {
                    get
                    {
                        return this.awardedPointsField;
                    }
                    set
                    {
                        this.awardedPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte usedAttempts
                {
                    get
                    {
                        return this.usedAttemptsField;
                    }
                    set
                    {
                        this.usedAttemptsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsFillInTheBlankQuestionExDetails
            {

                private object[] itemsField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute("blank", typeof(quizReportQuestionsFillInTheBlankQuestionExDetailsBlank))]
                [System.Xml.Serialization.XmlElementAttribute("text", typeof(string))]
                public object[] Items
                {
                    get
                    {
                        return this.itemsField;
                    }
                    set
                    {
                        this.itemsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsFillInTheBlankQuestionExDetailsBlank
            {

                private string answerField;

                private string userAnswerField;

                private bool correctField;

                /// <remarks/>
                public string answer
                {
                    get
                    {
                        return this.answerField;
                    }
                    set
                    {
                        this.answerField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string userAnswer
                {
                    get
                    {
                        return this.userAnswerField;
                    }
                    set
                    {
                        this.userAnswerField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public bool correct
                {
                    get
                    {
                        return this.correctField;
                    }
                    set
                    {
                        this.correctField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsFillInTheBlankSurveyQuestion
            {

                private string directionField;

                private quizReportQuestionsFillInTheBlankSurveyQuestionDetails detailsField;

                private string idField;

                private string statusField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                public quizReportQuestionsFillInTheBlankSurveyQuestionDetails details
                {
                    get
                    {
                        return this.detailsField;
                    }
                    set
                    {
                        this.detailsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsFillInTheBlankSurveyQuestionDetails
            {

                private object[] itemsField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute("blank", typeof(quizReportQuestionsFillInTheBlankSurveyQuestionDetailsBlank))]
                [System.Xml.Serialization.XmlElementAttribute("text", typeof(string))]
                public object[] Items
                {
                    get
                    {
                        return this.itemsField;
                    }
                    set
                    {
                        this.itemsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsFillInTheBlankSurveyQuestionDetailsBlank
            {

                private string userAnswerField;

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string userAnswer
                {
                    get
                    {
                        return this.userAnswerField;
                    }
                    set
                    {
                        this.userAnswerField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsLikertScaleQuestion
            {

                private string directionField;

                private string[] statementsField;

                private string[] scaleLabelsField;

                private quizReportQuestionsLikertScaleQuestionMatch[] userAnswerField;

                private string idField;

                private string statusField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("statement", IsNullable = false)]
                public string[] statements
                {
                    get
                    {
                        return this.statementsField;
                    }
                    set
                    {
                        this.statementsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("label", IsNullable = false)]
                public string[] scaleLabels
                {
                    get
                    {
                        return this.scaleLabelsField;
                    }
                    set
                    {
                        this.scaleLabelsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("match", IsNullable = false)]
                public quizReportQuestionsLikertScaleQuestionMatch[] userAnswer
                {
                    get
                    {
                        return this.userAnswerField;
                    }
                    set
                    {
                        this.userAnswerField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsLikertScaleQuestionMatch
            {

                private byte statementIndexField;

                private byte labelIndexField;

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte statementIndex
                {
                    get
                    {
                        return this.statementIndexField;
                    }
                    set
                    {
                        this.statementIndexField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte labelIndex
                {
                    get
                    {
                        return this.labelIndexField;
                    }
                    set
                    {
                        this.labelIndexField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMatchingQuestion
            {

                private string directionField;

                private string[] premisesField;

                private string[] responsesField;

                private quizReportQuestionsMatchingQuestionMatch[] matchesField;

                private quizReportQuestionsMatchingQuestionMatch1[] userAnswerField;

                private string idField;

                private string statusField;

                private byte maxPointsField;

                private byte maxAttemptsField;

                private byte awardedPointsField;

                private byte usedAttemptsField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("premise", IsNullable = false)]
                public string[] premises
                {
                    get
                    {
                        return this.premisesField;
                    }
                    set
                    {
                        this.premisesField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("response", IsNullable = false)]
                public string[] responses
                {
                    get
                    {
                        return this.responsesField;
                    }
                    set
                    {
                        this.responsesField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("match", IsNullable = false)]
                public quizReportQuestionsMatchingQuestionMatch[] matches
                {
                    get
                    {
                        return this.matchesField;
                    }
                    set
                    {
                        this.matchesField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("match", IsNullable = false)]
                public quizReportQuestionsMatchingQuestionMatch1[] userAnswer
                {
                    get
                    {
                        return this.userAnswerField;
                    }
                    set
                    {
                        this.userAnswerField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxPoints
                {
                    get
                    {
                        return this.maxPointsField;
                    }
                    set
                    {
                        this.maxPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxAttempts
                {
                    get
                    {
                        return this.maxAttemptsField;
                    }
                    set
                    {
                        this.maxAttemptsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte awardedPoints
                {
                    get
                    {
                        return this.awardedPointsField;
                    }
                    set
                    {
                        this.awardedPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte usedAttempts
                {
                    get
                    {
                        return this.usedAttemptsField;
                    }
                    set
                    {
                        this.usedAttemptsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMatchingQuestionMatch
            {

                private byte premiseIndexField;

                private byte responseIndexField;

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte premiseIndex
                {
                    get
                    {
                        return this.premiseIndexField;
                    }
                    set
                    {
                        this.premiseIndexField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte responseIndex
                {
                    get
                    {
                        return this.responseIndexField;
                    }
                    set
                    {
                        this.responseIndexField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMatchingQuestionMatch1
            {

                private byte premiseIndexField;

                private byte responseIndexField;

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte premiseIndex
                {
                    get
                    {
                        return this.premiseIndexField;
                    }
                    set
                    {
                        this.premiseIndexField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte responseIndex
                {
                    get
                    {
                        return this.responseIndexField;
                    }
                    set
                    {
                        this.responseIndexField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMatchingSurveyQuestion
            {

                private string directionField;

                private string[] premisesField;

                private string[] responsesField;

                private quizReportQuestionsMatchingSurveyQuestionMatch[] userAnswerField;

                private string idField;

                private string statusField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("premise", IsNullable = false)]
                public string[] premises
                {
                    get
                    {
                        return this.premisesField;
                    }
                    set
                    {
                        this.premisesField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("response", IsNullable = false)]
                public string[] responses
                {
                    get
                    {
                        return this.responsesField;
                    }
                    set
                    {
                        this.responsesField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("match", IsNullable = false)]
                public quizReportQuestionsMatchingSurveyQuestionMatch[] userAnswer
                {
                    get
                    {
                        return this.userAnswerField;
                    }
                    set
                    {
                        this.userAnswerField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMatchingSurveyQuestionMatch
            {

                private byte premiseIndexField;

                private byte responseIndexField;

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte premiseIndex
                {
                    get
                    {
                        return this.premiseIndexField;
                    }
                    set
                    {
                        this.premiseIndexField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte responseIndex
                {
                    get
                    {
                        return this.responseIndexField;
                    }
                    set
                    {
                        this.responseIndexField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMultipleChoiceQuestion
            {

                private string directionField;

                private quizReportQuestionsMultipleChoiceQuestionAnswers answersField;

                private string idField;

                private string statusField;

                private byte maxPointsField;

                private byte maxAttemptsField;

                private byte awardedPointsField;

                private byte usedAttemptsField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                public quizReportQuestionsMultipleChoiceQuestionAnswers answers
                {
                    get
                    {
                        return this.answersField;
                    }
                    set
                    {
                        this.answersField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxPoints
                {
                    get
                    {
                        return this.maxPointsField;
                    }
                    set
                    {
                        this.maxPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxAttempts
                {
                    get
                    {
                        return this.maxAttemptsField;
                    }
                    set
                    {
                        this.maxAttemptsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte awardedPoints
                {
                    get
                    {
                        return this.awardedPointsField;
                    }
                    set
                    {
                        this.awardedPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte usedAttempts
                {
                    get
                    {
                        return this.usedAttemptsField;
                    }
                    set
                    {
                        this.usedAttemptsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMultipleChoiceQuestionAnswers
            {

                private string[] answerField;

                private byte correctAnswerIndexField;

                private byte userAnswerIndexField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute("answer")]
                public string[] answer
                {
                    get
                    {
                        return this.answerField;
                    }
                    set
                    {
                        this.answerField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte correctAnswerIndex
                {
                    get
                    {
                        return this.correctAnswerIndexField;
                    }
                    set
                    {
                        this.correctAnswerIndexField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte userAnswerIndex
                {
                    get
                    {
                        return this.userAnswerIndexField;
                    }
                    set
                    {
                        this.userAnswerIndexField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMultipleChoiceTextQuestion
            {

                private string directionField;

                private quizReportQuestionsMultipleChoiceTextQuestionDetails detailsField;

                private string idField;

                private string statusField;

                private byte maxPointsField;

                private byte maxAttemptsField;

                private byte awardedPointsField;

                private byte usedAttemptsField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                public quizReportQuestionsMultipleChoiceTextQuestionDetails details
                {
                    get
                    {
                        return this.detailsField;
                    }
                    set
                    {
                        this.detailsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxPoints
                {
                    get
                    {
                        return this.maxPointsField;
                    }
                    set
                    {
                        this.maxPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxAttempts
                {
                    get
                    {
                        return this.maxAttemptsField;
                    }
                    set
                    {
                        this.maxAttemptsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte awardedPoints
                {
                    get
                    {
                        return this.awardedPointsField;
                    }
                    set
                    {
                        this.awardedPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte usedAttempts
                {
                    get
                    {
                        return this.usedAttemptsField;
                    }
                    set
                    {
                        this.usedAttemptsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMultipleChoiceTextQuestionDetails
            {

                private object[] itemsField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute("blank", typeof(quizReportQuestionsMultipleChoiceTextQuestionDetailsBlank))]
                [System.Xml.Serialization.XmlElementAttribute("text", typeof(string))]
                public object[] Items
                {
                    get
                    {
                        return this.itemsField;
                    }
                    set
                    {
                        this.itemsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMultipleChoiceTextQuestionDetailsBlank
            {

                private string[] answerField;

                private byte correctAnswerIndexField;

                private byte userAnswerIndexField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute("answer")]
                public string[] answer
                {
                    get
                    {
                        return this.answerField;
                    }
                    set
                    {
                        this.answerField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte correctAnswerIndex
                {
                    get
                    {
                        return this.correctAnswerIndexField;
                    }
                    set
                    {
                        this.correctAnswerIndexField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte userAnswerIndex
                {
                    get
                    {
                        return this.userAnswerIndexField;
                    }
                    set
                    {
                        this.userAnswerIndexField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMultipleChoiceTextSurveyQuestion
            {

                private string directionField;

                private quizReportQuestionsMultipleChoiceTextSurveyQuestionDetails detailsField;

                private string idField;

                private string statusField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                public quizReportQuestionsMultipleChoiceTextSurveyQuestionDetails details
                {
                    get
                    {
                        return this.detailsField;
                    }
                    set
                    {
                        this.detailsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMultipleChoiceTextSurveyQuestionDetails
            {

                public object[] itemsField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute("blank", typeof(quizReportQuestionsMultipleChoiceTextSurveyQuestionDetailsBlank))]
                [System.Xml.Serialization.XmlElementAttribute("text", typeof(string))]
                public object[] Items
                {
                    get
                    {
                        return this.itemsField;
                    }
                    set
                    {
                        this.itemsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMultipleChoiceTextSurveyQuestionDetailsBlank
            {

                private string[] answerField;

                private byte userAnswerIndexField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute("answer")]
                public string[] answer
                {
                    get
                    {
                        return this.answerField;
                    }
                    set
                    {
                        this.answerField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte userAnswerIndex
                {
                    get
                    {
                        return this.userAnswerIndexField;
                    }
                    set
                    {
                        this.userAnswerIndexField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMultipleResponseQuestion
            {

                private string directionField;

                private quizReportQuestionsMultipleResponseQuestionAnswer[] answersField;

                private string idField;

                private string statusField;

                private byte maxPointsField;

                private byte maxAttemptsField;

                private decimal awardedPointsField;

                private byte usedAttemptsField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("answer", IsNullable = false)]
                public quizReportQuestionsMultipleResponseQuestionAnswer[] answers
                {
                    get
                    {
                        return this.answersField;
                    }
                    set
                    {
                        this.answersField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxPoints
                {
                    get
                    {
                        return this.maxPointsField;
                    }
                    set
                    {
                        this.maxPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxAttempts
                {
                    get
                    {
                        return this.maxAttemptsField;
                    }
                    set
                    {
                        this.maxAttemptsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public decimal awardedPoints
                {
                    get
                    {
                        return this.awardedPointsField;
                    }
                    set
                    {
                        this.awardedPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte usedAttempts
                {
                    get
                    {
                        return this.usedAttemptsField;
                    }
                    set
                    {
                        this.usedAttemptsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsMultipleResponseQuestionAnswer
            {

                private bool correctField;

                private bool selectedField;

                private string valueField;

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public bool correct
                {
                    get
                    {
                        return this.correctField;
                    }
                    set
                    {
                        this.correctField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public bool selected
                {
                    get
                    {
                        return this.selectedField;
                    }
                    set
                    {
                        this.selectedField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlTextAttribute()]
                public string Value
                {
                    get
                    {
                        return this.valueField;
                    }
                    set
                    {
                        this.valueField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsNumericQuestion
            {

                private string directionField;

                private quizReportQuestionsNumericQuestionAnswers answersField;

                private string idField;

                private string statusField;

                private byte maxPointsField;

                private byte maxAttemptsField;

                private byte awardedPointsField;

                private byte usedAttemptsField;

                private uint userAnswerField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                public quizReportQuestionsNumericQuestionAnswers answers
                {
                    get
                    {
                        return this.answersField;
                    }
                    set
                    {
                        this.answersField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxPoints
                {
                    get
                    {
                        return this.maxPointsField;
                    }
                    set
                    {
                        this.maxPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxAttempts
                {
                    get
                    {
                        return this.maxAttemptsField;
                    }
                    set
                    {
                        this.maxAttemptsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte awardedPoints
                {
                    get
                    {
                        return this.awardedPointsField;
                    }
                    set
                    {
                        this.awardedPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte usedAttempts
                {
                    get
                    {
                        return this.usedAttemptsField;
                    }
                    set
                    {
                        this.usedAttemptsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public uint userAnswer
                {
                    get
                    {
                        return this.userAnswerField;
                    }
                    set
                    {
                        this.userAnswerField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsNumericQuestionAnswers
            {

                private byte equalField;

                /// <remarks/>
                public byte equal
                {
                    get
                    {
                        return this.equalField;
                    }
                    set
                    {
                        this.equalField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsNumericSurveyQuestion
            {

                private string directionField;

                private string idField;

                private string statusField;

                private byte userAnswerField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte userAnswer
                {
                    get
                    {
                        return this.userAnswerField;
                    }
                    set
                    {
                        this.userAnswerField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsPickManyQuestion
            {

                private string directionField;

                private quizReportQuestionsPickManyQuestionAnswer[] answersField;

                private string idField;

                private string statusField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("answer", IsNullable = false)]
                public quizReportQuestionsPickManyQuestionAnswer[] answers
                {
                    get
                    {
                        return this.answersField;
                    }
                    set
                    {
                        this.answersField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsPickManyQuestionAnswer
            {

                private bool selectedField;

                private string valueField;

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public bool selected
                {
                    get
                    {
                        return this.selectedField;
                    }
                    set
                    {
                        this.selectedField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlTextAttribute()]
                public string Value
                {
                    get
                    {
                        return this.valueField;
                    }
                    set
                    {
                        this.valueField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsPickOneQuestion
            {

                private string directionField;

                private quizReportQuestionsPickOneQuestionAnswers answersField;

                private string idField;

                private string statusField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                public quizReportQuestionsPickOneQuestionAnswers answers
                {
                    get
                    {
                        return this.answersField;
                    }
                    set
                    {
                        this.answersField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsPickOneQuestionAnswers
            {

                private string[] answerField;

                private byte userAnswerIndexField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute("answer")]
                public string[] answer
                {
                    get
                    {
                        return this.answerField;
                    }
                    set
                    {
                        this.answerField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte userAnswerIndex
                {
                    get
                    {
                        return this.userAnswerIndexField;
                    }
                    set
                    {
                        this.userAnswerIndexField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsRankingQuestion
            {

                private string directionField;

                private quizReportQuestionsRankingQuestionAnswer[] answersField;

                private string idField;

                private string statusField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("answer", IsNullable = false)]
                public quizReportQuestionsRankingQuestionAnswer[] answers
                {
                    get
                    {
                        return this.answersField;
                    }
                    set
                    {
                        this.answersField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsRankingQuestionAnswer
            {

                private byte originalIndexField;

                private string valueField;

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte originalIndex
                {
                    get
                    {
                        return this.originalIndexField;
                    }
                    set
                    {
                        this.originalIndexField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlTextAttribute()]
                public string Value
                {
                    get
                    {
                        return this.valueField;
                    }
                    set
                    {
                        this.valueField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsSequenceQuestion
            {

                private string directionField;

                private quizReportQuestionsSequenceQuestionAnswer[] answersField;

                private string idField;

                private string statusField;

                private byte maxPointsField;

                private byte maxAttemptsField;

                private decimal awardedPointsField;

                private byte usedAttemptsField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("answer", IsNullable = false)]
                public quizReportQuestionsSequenceQuestionAnswer[] answers
                {
                    get
                    {
                        return this.answersField;
                    }
                    set
                    {
                        this.answersField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxPoints
                {
                    get
                    {
                        return this.maxPointsField;
                    }
                    set
                    {
                        this.maxPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxAttempts
                {
                    get
                    {
                        return this.maxAttemptsField;
                    }
                    set
                    {
                        this.maxAttemptsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public decimal awardedPoints
                {
                    get
                    {
                        return this.awardedPointsField;
                    }
                    set
                    {
                        this.awardedPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte usedAttempts
                {
                    get
                    {
                        return this.usedAttemptsField;
                    }
                    set
                    {
                        this.usedAttemptsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsSequenceQuestionAnswer
            {

                private byte userDefinedPositionField;

                private string valueField;

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte userDefinedPosition
                {
                    get
                    {
                        return this.userDefinedPositionField;
                    }
                    set
                    {
                        this.userDefinedPositionField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlTextAttribute()]
                public string Value
                {
                    get
                    {
                        return this.valueField;
                    }
                    set
                    {
                        this.valueField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsShortAnswerQuestion
            {

                private string directionField;

                private string idField;

                private string statusField;

                private string userAnswerField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string userAnswer
                {
                    get
                    {
                        return this.userAnswerField;
                    }
                    set
                    {
                        this.userAnswerField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsTrueFalseQuestion
            {

                private string directionField;

                private quizReportQuestionsTrueFalseQuestionAnswers answersField;

                private string idField;

                private string statusField;

                private byte maxPointsField;

                private byte maxAttemptsField;

                private byte awardedPointsField;

                private byte usedAttemptsField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                public quizReportQuestionsTrueFalseQuestionAnswers answers
                {
                    get
                    {
                        return this.answersField;
                    }
                    set
                    {
                        this.answersField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxPoints
                {
                    get
                    {
                        return this.maxPointsField;
                    }
                    set
                    {
                        this.maxPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxAttempts
                {
                    get
                    {
                        return this.maxAttemptsField;
                    }
                    set
                    {
                        this.maxAttemptsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte awardedPoints
                {
                    get
                    {
                        return this.awardedPointsField;
                    }
                    set
                    {
                        this.awardedPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte usedAttempts
                {
                    get
                    {
                        return this.usedAttemptsField;
                    }
                    set
                    {
                        this.usedAttemptsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsTrueFalseQuestionAnswers
            {

                private string[] answerField;

                private byte correctAnswerIndexField;

                private byte userAnswerIndexField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute("answer")]
                public string[] answer
                {
                    get
                    {
                        return this.answerField;
                    }
                    set
                    {
                        this.answerField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte correctAnswerIndex
                {
                    get
                    {
                        return this.correctAnswerIndexField;
                    }
                    set
                    {
                        this.correctAnswerIndexField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte userAnswerIndex
                {
                    get
                    {
                        return this.userAnswerIndexField;
                    }
                    set
                    {
                        this.userAnswerIndexField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsWhichWordQuestion
            {

                private string directionField;

                private quizReportQuestionsWhichWordQuestionDetails detailsField;

                private string[] wordsField;

                private string idField;

                private string statusField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                public quizReportQuestionsWhichWordQuestionDetails details
                {
                    get
                    {
                        return this.detailsField;
                    }
                    set
                    {
                        this.detailsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayItemAttribute("word", IsNullable = false)]
                public string[] words
                {
                    get
                    {
                        return this.wordsField;
                    }
                    set
                    {
                        this.wordsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsWhichWordQuestionDetails
            {

                private object[] itemsField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute("blank", typeof(quizReportQuestionsWhichWordQuestionDetailsBlank))]
                [System.Xml.Serialization.XmlElementAttribute("text", typeof(string))]
                public object[] Items
                {
                    get
                    {
                        return this.itemsField;
                    }
                    set
                    {
                        this.itemsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsWhichWordQuestionDetailsBlank
            {

                private string userAnswerField;

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string userAnswer
                {
                    get
                    {
                        return this.userAnswerField;
                    }
                    set
                    {
                        this.userAnswerField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsWordBankQuestion
            {

                private string directionField;

                private quizReportQuestionsWordBankQuestionDetails detailsField;

                private string idField;

                private string statusField;

                private byte maxPointsField;

                private byte maxAttemptsField;

                private byte awardedPointsField;

                private byte usedAttemptsField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                public quizReportQuestionsWordBankQuestionDetails details
                {
                    get
                    {
                        return this.detailsField;
                    }
                    set
                    {
                        this.detailsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxPoints
                {
                    get
                    {
                        return this.maxPointsField;
                    }
                    set
                    {
                        this.maxPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte maxAttempts
                {
                    get
                    {
                        return this.maxAttemptsField;
                    }
                    set
                    {
                        this.maxAttemptsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte awardedPoints
                {
                    get
                    {
                        return this.awardedPointsField;
                    }
                    set
                    {
                        this.awardedPointsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte usedAttempts
                {
                    get
                    {
                        return this.usedAttemptsField;
                    }
                    set
                    {
                        this.usedAttemptsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsWordBankQuestionDetails
            {

                private object[] itemsField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute("text", typeof(string))]
                [System.Xml.Serialization.XmlElementAttribute("word", typeof(quizReportQuestionsWordBankQuestionDetailsWord))]
                public object[] Items
                {
                    get
                    {
                        return this.itemsField;
                    }
                    set
                    {
                        this.itemsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsWordBankQuestionDetailsWord
            {

                private bool correctField;

                private string userAnswerField;

                private string valueField;

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public bool correct
                {
                    get
                    {
                        return this.correctField;
                    }
                    set
                    {
                        this.correctField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string userAnswer
                {
                    get
                    {
                        return this.userAnswerField;
                    }
                    set
                    {
                        this.userAnswerField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlTextAttribute()]
                public string Value
                {
                    get
                    {
                        return this.valueField;
                    }
                    set
                    {
                        this.valueField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsYesNoQuestion
            {

                private string directionField;

                private quizReportQuestionsYesNoQuestionAnswers answersField;

                private string idField;

                private string statusField;

                /// <remarks/>
                public string direction
                {
                    get
                    {
                        return this.directionField;
                    }
                    set
                    {
                        this.directionField = value;
                    }
                }

                /// <remarks/>
                public quizReportQuestionsYesNoQuestionAnswers answers
                {
                    get
                    {
                        return this.answersField;
                    }
                    set
                    {
                        this.answersField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public string status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }
            }

            /// <remarks/>
            [System.SerializableAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.ispringsolutions.com/ispring/quizbuilder/quizresults")]
            public partial class quizReportQuestionsYesNoQuestionAnswers
            {

                private string[] answerField;

                private byte userAnswerIndexField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute("answer")]
                public string[] answer
                {
                    get
                    {
                        return this.answerField;
                    }
                    set
                    {
                        this.answerField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlAttributeAttribute()]
                public byte userAnswerIndex
                {
                    get
                    {
                        return this.userAnswerIndexField;
                    }
                    set
                    {
                        this.userAnswerIndexField = value;
                    }
                }
            }


        }
    }

