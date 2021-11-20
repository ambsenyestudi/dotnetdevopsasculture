# From depends on to network

Now we are adding a front end to our application, and since there are 3 containers running in our environment:
1. click_counter_web
2. click_counter_api
3. sqlserver

Since 3 is the magic number for changing something let's have all of those container in a net

# Creating a net

Previously we added a attribute depends_on to link *sqlserver* and *click_counter_api*, now that we have new container **click_counter_web** we are going to set all 3 of them in a network. Therefore, every servcie is going to have *network* attribute refering to **my_network**

> To create a new networt at the end of our docker-compose.yml I added at *network* that contains **my_network**. To define it for docker compose

Now if your run the app you can find the react app runing at http://localhost:3010 just the same

## Security warnning

To avoid having cors error in my react app I allow all origins in my click_counter_api at Startup.cs Configure method. As you can imagine, this is not a secure way to do do things.

In next section we will see about that.