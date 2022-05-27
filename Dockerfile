# fluentd/Dockerfile
FROM fluent/fluentd:v1.14.6-1.1
USER root
RUN ["gem", "install", "fluent-plugin-elasticsearch", "--version", "5.2.0"]
USER fluent