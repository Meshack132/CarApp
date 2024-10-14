#!/bin/bash

echo "Starting deployment..."

# Build the project
dotnet publish -c Release -o out

# Copy the files to your server (customize this part)
scp -r out/* user@your-server:/path/to/deploy

echo "Deployment completed!"
