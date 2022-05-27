# Cloud native logging with serilog-udp-efk-intergration

`Cloud native logging` has two workers that log using serilog-udp and logs will be forwarded to elastic search using fluentd.

## How to run

Make sure you have Docker installed. Then change your current directory to the root of the project and run 

```console
docker-compose up -d
```
Then you can visit localhost:5601 to check created indexes in Elasticsearch.

After checking up and running services, you can create DataView (previously named index-pattern) in Kibana to review logs.
```
http://localhost:5601
```
NOTE: logs can be structured and compacted using serilog-compact-json enricher.