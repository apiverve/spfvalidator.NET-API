using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Authorizedips data
    /// </summary>
    public class Authorizedips
    {
        [JsonProperty("ipv4")]
        public string[] Ipv4 { get; set; }

    }
    /// <summary>
    /// Authorizedips data
    /// </summary>
    public class Authorizedips
    {
        [JsonProperty("ipv4")]
        public string[] Ipv4 { get; set; }

    }
    /// <summary>
    /// Spfrecordslist data
    /// </summary>
    public class Spfrecordslist
    {
        [JsonProperty("authorized_ips")]
        public Authorizedips Authorizedips { get; set; }

        [JsonProperty("chars_num")]
        public int Charsnum { get; set; }

        [JsonProperty("domains")]
        public string[] Domains { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("record")]
        public string Record { get; set; }

        [JsonProperty("use_macro")]
        public bool Usemacro { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("authorized_ips")]
        public Authorizedips Authorizedips { get; set; }

        [JsonProperty("dns_lookups_num")]
        public int Dnslookupsnum { get; set; }

        [JsonProperty("domains_extracted")]
        public string[] Domainsextracted { get; set; }

        [JsonProperty("elapsed_ms")]
        public int Elapsedms { get; set; }

        [JsonProperty("has_issues")]
        public bool Hasissues { get; set; }

        [JsonProperty("has_spf_record")]
        public bool Hasspfrecord { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("ip_pass")]
        public bool Ippass { get; set; }

        [JsonProperty("macros_found")]
        public bool Macrosfound { get; set; }

        [JsonProperty("spf_record")]
        public string Spfrecord { get; set; }

        [JsonProperty("spf_records_list")]
        public Spfrecordslist[] Spfrecordslist { get; set; }

        [JsonProperty("spf_valid")]
        public bool Spfvalid { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
