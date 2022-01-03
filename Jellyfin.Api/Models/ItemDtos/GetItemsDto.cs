using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Jellyfin.Data.Enums;
using Jellyfin.Extensions.Json.Converters;
using MediaBrowser.Model.Entities;
using MediaBrowser.Model.Querying;

namespace Jellyfin.Api.Models.ItemDtos
{
    /// <summary>
    /// Get items dto.
    /// </summary>
    public class GetItemsDto
    {
        /// <summary>
        /// Gets or sets optional. Filter by user id.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by maximum official rating (PG, PG-13, TV-MA, etc).
        /// Optional
        /// </summary>
        public string? MaxOfficialRating { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items with theme songs.
        /// Optional
        /// </summary>
        public bool? HasThemeSong { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items with theme videos.
        /// Optional
        /// </summary>
        public bool? HasThemeVideo { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items with subtitles.
        /// Optional
        /// </summary>
        public bool? HasSubtitles { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items with special features.
        /// Optional
        /// </summary>
        public bool? HasSpecialFeature { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items with trailers.
        /// Optional
        /// </summary>
        public bool? HasTrailer { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items that are siblings of a supplied item.
        /// Optional
        /// </summary>
        public string? AdjacentTo { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by parent index number.
        /// Optional
        /// </summary>
        public int? ParentIndexNumber { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items that have or do not have a parental rating.
        /// Optional
        /// </summary>
        public bool? HasParentalRating { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items that are HD or not.
        /// Optional
        /// </summary>
        public bool? IsHd { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items that are 4K or not.
        /// Optional
        /// </summary>
        public bool? Is4K { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter based on LocationTypes.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<LocationType> LocationTypes { get; set; } = Array.Empty<LocationType>();

        /// <summary>
        /// Gets or sets optional. Filter based on the LocationType.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<LocationType> ExcludeLocationTypes { get; set; } = Array.Empty<LocationType>();

        /// <summary>
        /// Gets or sets optional. Filter by items that are missing episodes or not.
        /// Optional
        /// </summary>
        public bool? IsMissing { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items that are unaired episodes or not.
        /// Optional
        /// </summary>
        public bool? IsUnaired { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by minimum community rating.
        /// Optional
        /// </summary>
        public double? MinCommunityRating { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by minimum critic rating.
        /// Optional
        /// </summary>
        public double? MinCriticRating { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by the minimum premiere date. Format = ISO.
        /// Optional
        /// </summary>
        public DateTime? MinPremiereDate { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by the minimum last saved date. Format = ISO.
        /// Optional
        /// </summary>
        public DateTime? MinDateLastSaved { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by the minimum last saved date for the current user. Format = ISO.
        /// Optional
        /// </summary>
        public DateTime? MinDateLastSavedForUser { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by the maximum premiere date. Format = ISO.
        /// Optional
        /// </summary>
        public DateTime? MaxPremiereDate { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items that have an overview or not.
        /// Optional
        /// </summary>
        public bool? HasOverview { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items that have an imdb id or not.
        /// Optional
        /// </summary>
        public bool? HasImdbId { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items that have a tmdb id or not.
        /// Optional
        /// </summary>
        public bool? HasTmdbId { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items that have a tvdb id or not.
        /// Optional
        /// </summary>
        public bool? HasTvdbId { get; set; }

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered by excluding item ids.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<Guid> ExcludeItemIds { get; set; } = Array.Empty<Guid>();

        /// <summary>
        /// Gets or sets optional. The record index to start at. All items with a lower index will be dropped from the results.
        /// Optional
        /// </summary>
        public int? StartIndex { get; set; }

        /// <summary>
        /// Gets or sets optional. The maximum number of records to return.
        /// Optional
        /// </summary>
        public int? Limit { get; set; }

        /// <summary>
        /// Gets or sets optional. When searching within folders, this determines whether or not the search will be recursive. true/false.
        /// Optional
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter based on a search term.
        /// Optional
        /// </summary>
        public string? SearchTerm { get; set; }

        /// <summary>
        /// Gets or sets optional. Ascending,Descending.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<SortOrder> SortOrder { get; set; } = Array.Empty<SortOrder>();

        /// <summary>
        /// Gets or sets optional. Specify this to localize the search to a specific item or folder. Omit to use the root.
        /// Optional
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Gets or sets optional. Specify additional fields of information to return in the output.
        /// Options: Budget, Chapters, DateCreated, Genres, HomePageUrl, IndexOptions, MediaStreams, Overview, ParentId, Path, People, ProviderIds, PrimaryImageAspectRatio, Revenue, SortName, Studios, Taglines.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<ItemFields> Fields { get; set; } = Array.Empty<ItemFields>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on item type.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<BaseItemKind> ExcludeItemTypes { get; set; } = Array.Empty<BaseItemKind>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on the item type.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<BaseItemKind> IncludeItemTypes { get; set; } = Array.Empty<BaseItemKind>();

        /// <summary>
        /// Gets or sets optional.  Specify additional filters to apply.
        /// Options: IsFolder, IsNotFolder, IsUnplayed, IsPlayed, IsFavorite, IsResumable, Likes, Dislikes.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<ItemFilter> Filters { get; set; } = Array.Empty<ItemFilter>();

        /// <summary>
        /// Gets or sets optional. Filter by items that are marked as favorite, or not.
        /// Optional
        /// </summary>
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by MediaType.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<string> MediaTypes { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on those containing image types.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<ImageType> ImageTypes { get; set; } = Array.Empty<ImageType>();

        /// <summary>
        /// Gets or sets optional. Specify one or more sort orders.
        /// Options: Album, AlbumArtist, Artist, Budget, CommunityRating, CriticRating, DateCreated, DatePlayed, PlayCount, PremiereDate, ProductionYear, SortName, Random, Revenue, Runtime.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<string> SortBy { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Gets or sets optional. Filter by items that are played, or not.
        /// Optional
        /// </summary>
        public bool? IsPlayed { get; set; }

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on genre.
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<string> Genres { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on OfficialRating.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<string> OfficialRatings { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on tag.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<string> Tags { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on production year.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<int> Years { get; set; } = Array.Empty<int>();

        /// <summary>
        /// Gets or sets optional. Include user data.
        /// Optional
        /// </summary>
        public bool? EnableUserData { get; set; }

        /// <summary>
        /// Gets or sets optional. The max number of images to return, per image type.
        /// Optional
        /// </summary>
        public int? ImageTypeLimit { get; set; }

        /// <summary>
        /// Gets or sets optional. The image types to include in the output.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<ImageType> EnableImageTypes { get; set; } = Array.Empty<ImageType>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered to include only those containing the specified person.
        /// Optional
        /// </summary>
        public string? Person { get; set; }

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered to include only those containing the specified person id.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<Guid> PersonIds { get; set; } = Array.Empty<Guid>();

        /// <summary>
        /// Gets or sets optional.  If specified, along with Person, results will be filtered to include only those containing the specified person and PersonType.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<string> PersonTypes { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on studios.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<string> Studios { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on artists.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<string> Artists { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on artist ids.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<Guid> ExcludeArtistIds { get; set; } = Array.Empty<Guid>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered to include only those containing the specified artist ids.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<Guid> ArtistIds { get; set; } = Array.Empty<Guid>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered to include only those containing the specified album artist ids.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<Guid> AlbumArtistIds { get; set; } = Array.Empty<Guid>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered to include only those containing the specified contributing artist id.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<Guid> ContributingArtistIds { get; set; } = Array.Empty<Guid>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on albums.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<string> Albums { get; set; } = Array.Empty<string>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on album ids.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<Guid> AlbumIds { get; set; } = Array.Empty<Guid>();

        /// <summary>
        /// Gets or sets optional. If specific items are needed, specify a list of item id's to retrieve.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<Guid> Ids { get; set; } = Array.Empty<Guid>();

        /// <summary>
        /// Gets or sets optional. Filter by VideoType (videofile, dvd, bluray, iso).
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<VideoType> VideoTypes { get; set; } = Array.Empty<VideoType>();

        /// <summary>
        /// Gets or sets optional. Filter by minimum official rating (PG, PG-13, TV-MA, etc)
        /// Optional
        /// </summary>
        public string? MinOfficialRating { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items that are locked.
        /// Optional
        /// </summary>
        public bool? IsLocked { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items that are placeholders.
        /// Optional
        /// </summary>
        public bool? IsPlaceHolder { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items that have official ratings.
        /// Optional
        /// </summary>
        public bool? HasOfficialRating { get; set; }

        /// <summary>
        /// Gets or sets optional. Whether or not to hide items behind their boxsets.
        /// Optional
        /// </summary>
        public bool? CollapseBoxSetItems { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by the minimum width of the item.
        /// Optional
        /// </summary>
        public int? MinWidth { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by the minimum height of the item.
        /// Optional
        /// </summary>
        public int? MinHeight { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by the maximum width of the item.
        /// Optional
        /// </summary>
        public int? MaxWidth { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by the maximum height of the item.
        /// Optional
        /// </summary>
        public int? MaxHeight { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by ems that are 3D, or not.
        /// Optional
        /// </summary>
        public bool? Is3D { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by Series Statuses.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<SeriesStatus> SeriesStatus { get; set; } = Array.Empty<SeriesStatus>();

        /// <summary>
        /// Gets or sets optional. Filter by items whose name is sorted equally or greater than a given input string.
        /// Optional
        /// </summary>
        public string? NameStartsWithOrGreater { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items whose name is sorted equally than a given input string.
        /// Optional
        /// </summary>
        public string? NameStartsWith { get; set; }

        /// <summary>
        /// Gets or sets optional. Filter by items whose name is equally or lesser than a given input string.
        /// Optional
        /// </summary>
        public string? NameLessThan { get; set; }

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on studio ids.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<Guid> StudioIds { get; set; } = Array.Empty<Guid>();

        /// <summary>
        /// Gets or sets optional. If specified, results will be filtered based on genre ids.
        /// Optional
        /// </summary>
        [JsonConverter(typeof(JsonCommaDelimitedArrayConverterFactory))]
        public IReadOnlyList<Guid> GenreIds { get; set; } = Array.Empty<Guid>();

        /// <summary>
        /// Gets or sets optional. Enable the total record count.
        /// Optional
        /// </summary>
        public bool EnableTotalRecordCount { get; set; } = true;

        /// <summary>
        /// Gets or sets optional. Include image information in output.
        /// Optional
        /// </summary>
        public bool enableImages { get; set; } = true;
    }
}
