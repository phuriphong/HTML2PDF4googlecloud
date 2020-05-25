FROM gcr.io/google-appengine/aspnetcore:2.2
COPY . /app
# install System.Drawing native dependencies
RUN apt-get update \
    && apt-get install -y --allow-unauthenticated \
        libc6-dev \
        libgdiplus \
        libx11-dev \
     && rm -rf /var/lib/apt/lists/*

WORKDIR /app
ENTRYPOINT ["dotnet", "ReportPDF.dll"]
