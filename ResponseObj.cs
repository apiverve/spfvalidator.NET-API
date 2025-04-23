using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class authorizedips
{
    [JsonProperty("ipv4")]
    public string[] ipv4 { get; set; }

}

public class authorizedips
{
    [JsonProperty("ipv4")]
    public string[] ipv4 { get; set; }

}

public class spfrecordslist
{
    [JsonProperty("authorized_ips")]
    public authorizedips authorizedips { get; set; }

    [JsonProperty("chars_num")]
    public int charsnum { get; set; }

    [JsonProperty("domains")]
    public string[] domains { get; set; }

    [JsonProperty("origin")]
    public string origin { get; set; }

    [JsonProperty("record")]
    public string record { get; set; }

    [JsonProperty("use_macro")]
    public bool usemacro { get; set; }

}

public class data
{
    [JsonProperty("authorized_ips")]
    public authorizedips authorizedips { get; set; }

    [JsonProperty("dns_lookups_num")]
    public int dnslookupsnum { get; set; }

    [JsonProperty("domains_extracted")]
    public string[] domainsextracted { get; set; }

    [JsonProperty("elapsed_ms")]
    public int elapsedms { get; set; }

    [JsonProperty("has_issues")]
    public bool hasissues { get; set; }

    [JsonProperty("has_spf_record")]
    public bool hasspfrecord { get; set; }

    [JsonProperty("host")]
    public string host { get; set; }

    [JsonProperty("ip_pass")]
    public bool ippass { get; set; }

    [JsonProperty("macros_found")]
    public bool macrosfound { get; set; }

    [JsonProperty("spf_record")]
    public string spfrecord { get; set; }

    [JsonProperty("spf_records_list")]
    public spfrecordslist[] spfrecordslist { get; set; }

    [JsonProperty("spf_valid")]
    public bool spfvalid { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
