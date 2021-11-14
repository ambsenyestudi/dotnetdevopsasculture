# get the base node image
FROM node:16-alpine

# set the working dir for container
WORKDIR /frontend

# copy the json file first
COPY ./package.json .

# install npm dependencies
RUN npm install

# copy other project files
COPY . .

EXPOSE 3000

CMD ["npm", "start"]