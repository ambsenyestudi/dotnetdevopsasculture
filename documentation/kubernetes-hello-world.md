# Kuberetes: Hello world

We need to run kub:
kubectl create -f .\k8s-hello-world-pod.yaml
kubectl create -f .\k8s-hello-world-svc.yaml

Get tcp port
kubectl get service hello-world-web

Get name of pod
kubectl get pod

Check that it is alive through logs
kubectl logs hello-world-web


or apply depending
kubectl get pod --show-labels
to see the tier label

kubectl get service
to see the port auto genereted by k8s

kubectl describe svc hello-world-web
to see the ip, does not work on windows docker desktop

kubectl describe node docker-desktop and then internal ip does not work ether

out of depseration chance service spect type to loadbalancer target por 80
and on pod I added target port 80

Todo test only:

kubectl apply -f .\k8s-hello-world-deploy.yaml

this works the pod thing doesn't

Nodeport is a pod accessible form a static port that is in the range (30000-32767) Accessible at ip address of the worker node in docker desktop localhost?
mayb try:

kubectl expose pod (podname) --type=NodePort from [this article](https://kubernetesquestions.com/questions/59027090)

[types of services](https://www.youtube.com/watch?v=T4Z7visMM4E)