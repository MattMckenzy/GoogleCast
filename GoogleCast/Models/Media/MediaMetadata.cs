using System;
using System.Runtime.Serialization;

namespace GoogleCast.Models.Media
{
    [DataContract]
    public class MediaMetadata
    {
        /// <summary>
        /// Gets the metadata type
        /// </summary>
        [DataMember(Name = "metadataType")]
        public MetadataType MetadataType { get; set; }

        /// <summary>
        /// Gets or sets the descriptive title of the content
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the descriptive subtitle of the content
        /// </summary>
        [DataMember(Name = "subtitle")]
        public string Subtitle { get; set; }

        /// <summary>
        /// Gets or sets an array of URL(s) to an image associated with the content
        /// </summary>
        [DataMember(Name = "images")]
        public Image[] Images { get; set; }

        /// <summary>
        /// Gets or sets the release date of the content
        /// </summary>
        [DataMember(Name = "releaseDate")]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// Gets or sets the studio
        /// </summary>
        [DataMember(Name = "studio")]
        public string Studio { get; set; }

        /// <summary>
        /// Gets or sets the descriptive series title of the content
        /// </summary>
        [DataMember(Name = "seriesTitle")]
        public string SeriesTitle { get; set; }

        /// <summary>
        /// Gets or sets the season number of the content
        /// </summary>
        [DataMember(Name = "season")]
        public int? Season { get; set; }

        /// <summary>
        /// Gets or sets the episode number of the content
        /// </summary>
        [DataMember(Name = "episode")]
        public int? Episode { get; set; }

        /// <summary>
        /// Gets or sets the original air date of the content
        /// </summary>
        [DataMember(Name = "originalAirDate")]
        public string OriginalAirDate { get; set; }

        /// <summary>
        /// Gets or sets the descriptive album name of the content
        /// </summary>
        [DataMember(Name = "albumName")]
        public string AlbumName { get; set; }

        /// <summary>
        /// Gets or sets the descriptive album artist of the content
        /// </summary>
        [DataMember(Name = "albumArtist")]
        public string AlbumArtist { get; set; }

        /// <summary>
        /// Gets or sets the descriptive artist of the content
        /// </summary>
        [DataMember(Name = "artist")]
        public string Artist { get; set; }

        /// <summary>
        /// Gets or sets the descriptive composer of the content
        /// </summary>
        [DataMember(Name = "composer")]
        public string Composer { get; set; }

        /// <summary>
        /// Gets or sets the track number of the content
        /// </summary>
        [DataMember(Name = "trackNumber")]
        public int? TrackNumber { get; set; }

        /// <summary>
        /// Gets or sets the disc number of the content
        /// </summary>
        [DataMember(Name = "discNumber")]
        public int? DiscNumber { get; set; }

        /// <summary>
        /// Gets or sets the descriptive location of the content
        /// </summary>
        [DataMember(Name = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the latitude of the content
        /// </summary>
        [DataMember(Name = "latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude of the content
        /// </summary>
        [DataMember(Name = "longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or sets the width of the content
        /// </summary>
        [DataMember(Name = "width")]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the content
        /// </summary>
        [DataMember(Name = "height")]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the content
        /// </summary>
        [DataMember(Name = "creationDateTime")]
        public string CreationDateTime { get; set; }
    }
}