// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace MicrosoftNewsAPI.SDK.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MsnTagsDataModelTagEntityLibArtifactDataHeadline
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibArtifactDataHeadline class.
        /// </summary>
        public MsnTagsDataModelTagEntityLibArtifactDataHeadline()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibArtifactDataHeadline class.
        /// </summary>
        public MsnTagsDataModelTagEntityLibArtifactDataHeadline(string title = default(string), string subTitle = default(string), string kicker = default(string), string imageCaption = default(string), MsnTagsDataModelTagEntityLibArtifactDataImage image = default(MsnTagsDataModelTagEntityLibArtifactDataImage))
        {
            Title = title;
            SubTitle = subTitle;
            Kicker = kicker;
            ImageCaption = imageCaption;
            Image = image;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subTitle")]
        public string SubTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "kicker")]
        public string Kicker { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "imageCaption")]
        public string ImageCaption { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public MsnTagsDataModelTagEntityLibArtifactDataImage Image { get; set; }

    }
}
