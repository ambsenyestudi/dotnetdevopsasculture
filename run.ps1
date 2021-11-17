docker run `
    --rm `
    -it `
    --name click_count_api_local `
    -p 5010:5000 `
    --network=click_count_network `
    click_count_api:v0.1