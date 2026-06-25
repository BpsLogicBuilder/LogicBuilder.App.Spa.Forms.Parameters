using LogicBuilder.Attributes;

namespace LogicBuilder.App.Spa.Forms.Parameters.Common
{
    public class DomainRequestParameters(
            [Comments("Defines the request state including the sort, filter, page and page size.")]
            DataRequestStateParameters state,

            [Comments("URL and other meta data for the data request.")]
            RequestDetailsParameters requestDetails
        )
    {
        public DataRequestStateParameters State { get; } = state;
        public RequestDetailsParameters RequestDetails { get; } = requestDetails;
    }
}