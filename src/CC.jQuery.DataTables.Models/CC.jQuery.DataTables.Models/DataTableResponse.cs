// NOTE: Most if not all documentation was taken from https://datatables.net/manual/server-side

using System;

namespace CC.jQuery.DataTables.Models
{
    /// <summary>
    /// Represents the response from the server that will be sent back to the client.
    /// </summary>
    /// <typeparam name="TData">
    /// The type of the data in the response Data property. Must be a class.
    /// </typeparam>
    public class DataTableResponse<TData> where TData : class
    {
        /// <summary>
        /// The draw counter that this object is a response to - from the draw parameter sent as part of the data request.
        /// Note that it is strongly recommended for security reasons that you cast this parameter to an integer, rather than
        /// simply echoing back to the client what it sent in the draw parameter, in order to prevent Cross Site Scripting (XSS) attacks.
        /// </summary>
        public int Draw
        {
            get; set;
        }

        /// <summary>
        /// Total records, before filtering (i.e. the total number of records in the database)
        /// </summary>
        public int RecordsTotal
        {
            get;
            set;
        }

        /// <summary>
        /// Total records, after filtering (i.e. the total number of records after filtering has been applied - not just the number of records
        /// being returned for this page of data).
        /// </summary>
        public int RecordsFiltered
        {
            get;
            set;
        }

        private TData[] _data;
        /// <summary>
        /// The data to be displayed in the table. This is an array of data source objects, one for each row, which will be used by DataTables.
        /// Note that this parameter's name can be changed using the ajax option's dataSrc property.
        /// </summary>
        public TData[] Data
        {
            get => _data ?? Array.Empty<TData>();
            set => _data = value;
        }

        /// <summary>
        /// Optional: If an error occurs during the running of the server-side processing script,
        /// you can inform the user of this error by passing back the error message to be displayed using this parameter.
        /// Do not include if there is no error.
        /// </summary>
        public string Error
        {
            get; 
            set;
        }
    }
}
