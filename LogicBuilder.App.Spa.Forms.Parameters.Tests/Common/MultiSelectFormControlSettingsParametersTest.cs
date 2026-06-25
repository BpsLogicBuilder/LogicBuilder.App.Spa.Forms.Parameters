using LogicBuilder.App.Spa.Forms.Parameters.Common;
using LogicBuilder.Forms.Parameters.Expressions;
using System.Collections.Generic;
using Xunit;

namespace LogicBuilder.App.Spa.Forms.Parameters.Tests.Common
{
    public class MultiSelectFormControlSettingsParametersTest
    {
        [Fact]
        public void Constructor_WithRequiredParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var keyFields = new List<string> { "CourseId" };
            var textAndValueSelector = new SelectorLambdaOperatorParameters(null!, null!, null!);
            var requestDetails = new RequestDetailsParameters(
                "MyApp.Domain.Entities.Course",
                "MyApp.Data.Entities.Course",
                "System.Collections.Generic.IEnumerable`1",
                "System.Collections.Generic.IEnumerable`1"
            );
            var multiSelectTemplate = new MultiSelectTemplateParameters(
                "multiSelectTemplate",
                "Select courses...",
                "CourseName",
                "CourseId",
                textAndValueSelector,
                requestDetails
            );

            // Act
            var parameters = new MultiSelectFormControlSettingsParameters(
                keyFields: keyFields,
                field: "Courses",
                domElementId: "courses_id",
                title: "Courses",
                placeHolder: "Select courses",
                type: "text",
                multiSelectTemplate: multiSelectTemplate
            );

            // Assert
            Assert.Equal(AbstractControlType.MultiSelectFormControl, parameters.AbstractControlType);
            Assert.Equal(keyFields, parameters.KeyFields);
            Assert.Equal("Courses", parameters.Field);
            Assert.Equal("courses_id", parameters.DomElementId);
            Assert.Equal("Courses", parameters.Title);
            Assert.Equal("Select courses", parameters.Placeholder);
            Assert.Equal("text", parameters.Type);
            Assert.Equal(multiSelectTemplate, parameters.MultiSelectTemplate);
            Assert.Null(parameters.ValidationSetting);
            Assert.Null(parameters.ModelType);
        }

        [Fact]
        public void Constructor_WithAllParameters_SetsPropertiesCorrectly()
        {
            // Arrange
            var keyFields = new List<string> { "TagId" };
            var textAndValueSelector = new SelectorLambdaOperatorParameters(null!, null!, null!);
            var requestDetails = new RequestDetailsParameters(
                "MyApp.Domain.Entities.Tag",
                "MyApp.Data.Entities.Tag",
                "System.Collections.Generic.List`1",
                "System.Collections.Generic.List`1"
            );
            var multiSelectTemplate = new MultiSelectTemplateParameters(
                "tagMultiSelect",
                "Choose tags...",
                "TagName",
                "TagId",
                textAndValueSelector,
                requestDetails
            );
            var validationSetting = new FormValidationSettingParameters();

            // Act
            var parameters = new MultiSelectFormControlSettingsParameters(
                keyFields: keyFields,
                field: "Tags",
                domElementId: "tags_id",
                title: "Tags",
                placeHolder: "Choose tags",
                type: "text",
                multiSelectTemplate: multiSelectTemplate,
                validationSetting: validationSetting,
                modelType: "MyApp.Domain.Entities.Post"
            );

            // Assert
            Assert.Equal(AbstractControlType.MultiSelectFormControl, parameters.AbstractControlType);
            Assert.Equal(keyFields, parameters.KeyFields);
            Assert.Equal("Tags", parameters.Field);
            Assert.Equal("tags_id", parameters.DomElementId);
            Assert.Equal("Tags", parameters.Title);
            Assert.Equal("Choose tags", parameters.Placeholder);
            Assert.Equal("text", parameters.Type);
            Assert.Equal(multiSelectTemplate, parameters.MultiSelectTemplate);
            Assert.Equal(validationSetting, parameters.ValidationSetting);
            Assert.Equal("MyApp.Domain.Entities.Post", parameters.ModelType);
        }
    }
}
