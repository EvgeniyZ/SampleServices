Build images for both AuthenticationService and UniversityService 

In AuthenticationService/ folder

`docker build -t authentication .`

In UniversitryService/ folder

`docker build -t university .`

After that, in docker/

`docker-compose up`
