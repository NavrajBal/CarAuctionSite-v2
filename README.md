# Quick Start Guide

## Run with Docker (Recommended)
docker-compose up -d

## Services will be available at:
- API Gateway: http://localhost:6001
- Auction Service: http://localhost:7001
- Search Service: http://localhost:7002  
- Identity Service: http://localhost:5001
- RabbitMQ Management: http://localhost:15672 (guest/guest)

## Stop services
docker-compose down
## Troubleshooting

### If Docker build fails:
docker-compose build --no-cache

### Check service logs:
docker-compose logs auction-svc
docker-compose logs search-svc

### Reset everything:
docker-compose down -v
docker system prune -f

### Check if ports are in use:
lsof -i :5432  # PostgreSQL
lsof -i :27017 # MongoDB
lsof -i :5672  # RabbitMQ
